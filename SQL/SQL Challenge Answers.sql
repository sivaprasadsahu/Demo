-- Campsites Table
CREATE TABLE Campsites (
    id INT PRIMARY KEY,
    name VARCHAR(50),
    capacity INT,
    price DECIMAL(10, 2)
);

-- Reservations table

CREATE TABLE Reservations (
    id INT PRIMARY KEY,
    campsite_id INT,
    start_date DATE,
    end_date DATE,
    number_of_people INT,
    CONSTRAINT FK_Campsite FOREIGN KEY (campsite_id) REFERENCES Campsites(id)
);

-- Visitors table

CREATE TABLE Visitors (
    id INT PRIMARY KEY,
    visit_date DATE,
    number_of_visitors INT
);

-- Populate the tables with some dummy data:

INSERT INTO Campsites (id, name, capacity, price) VALUES
(1, 'Site A', 6, 25.00),
(2, 'Site B', 4, 20.00),
(3, 'Site C', 8, 30.00);

INSERT INTO Reservations (id, campsite_id, start_date, end_date, number_of_people) VALUES
(1, 1, '2023-06-01', '2023-06-03', 4),
(2, 1, '2023-06-15', '2023-06-20', 6),
(3, 2, '2023-07-01', '2023-07-05', 3),
(4, 3, '2023-08-10', '2023-08-14', 8);

INSERT INTO Visitors (id, visit_date, number_of_visitors) VALUES
(1, '2023-06-01', 200),
(2, '2023-06-02', 150),
(3, '2023-06-03', 100),
(4, '2023-06-04', 125),
(5, '2023-06-05', 100),
(6, '2023-06-06', 75),
(7, '2023-06-07', 50),
(8, '2023-06-08', 100),
(9, '2023-06-09', 150),
(10, '2023-06-10', 200);

-- Add Reservation stored procedure

CREATE PROCEDURE AddReservation
    @campsite_id INT,
    @start_date DATE,
    @end_date DATE,
    @number_of_people INT
AS
BEGIN
    INSERT INTO Reservations (campsite_id, start_date, end_date, number_of_people)
    VALUES (@campsite_id, @start_date, @end_date, @number_of_people);
END

--Cancel Reservation stored procedure

CREATE PROCEDURE CancelReservation
    @reservation_id INT
AS
BEGIN
    DELETE FROM Reservations WHERE id = @reservation_id;
END

-- Create a view to show available campsite reservation dates:

CREATE VIEW AvailableReservations AS
    SELECT c.name AS CampsiteName, c.capacity, c.price,
        r.start_date, r.end_date, (c.capacity - SUM(r.number_of_people)) AS AvailableSpots
    FROM Campsites c
    LEFT JOIN Reservations r ON c.id = r.campsite_id AND (GETDATE() < r.start_date OR r.end_date < GETDATE())
    GROUP BY c.id, c.name, c.capacity, c.price, r.start_date, r.end_date;

-- Function that shows the most popular day to visit the canyon 

CREATE FUNCTION MostPopularVisitDate()
RETURNS DATE
AS
BEGIN
    DECLARE @date DATE
    SELECT TOP 1 @date = visit_date
    FROM Visitors
    GROUP BY visit_date
    ORDER BY SUM(number_of_visitors) DESC;
    
    RETURN @date;
END



