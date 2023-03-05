# SQL Code Challenges

## Challenge: Camp Site Tracking

Millcreek Canyon management has asked you to create a table to store campsites, existing reservations, and available reservation dates for each campsite, and they would also like to know the number of visitors to the canyon each day. 

### Instructions

- Please use relational tables to track this information 
- Populate the tables with a small amount of dummy data 
- The data does not have to be accurate to Millcreek canyon real world specifications 
- Create stored procedure(s) to add or cancel a reservation 
- Don’t worry about updating information on an existing reservation for this problem 
- Create a view to show available campsite reservation dates 
- Create a function that shows the most popular day to visit the canyon 

## Challenge: Duplicate Email Addresses

Write a SQL query that will return duplicate email addresses in an `Employee` Table.

### Example

**Employee**

| employeeId  | email                     |
|-------------|---------------------------|
| 1           | bob.smith@somwhere.com    |
| 2           | eric.jones@somewhere.com  |
| 3           | Jill.brown@somewhere.com  |
| 4           | bob.smith@somwhere.com    |

**The query would result in:**

| email                   |
|-------------------------|
| bob.smith@somwhere.com  |

## Challenge: Department Highest Salaries

Write a query that will find the employees that have the highest salary for their department. If multiple employees share the same salary, the result should include both employees. The result should include the department name, employee name and the salary.

The Employee table stores an employeeId, name, salary and departmentId.

The Department table stores a departmentId and a name.

### Example

**Employee**

| employeeId  | name   | salary  | departmentId  |
|-------------|--------|---------|---------------|
| 1           | Eric   | 85000   | 1             |
| 2           | Jill   | 95000   | 1             |
| 3           | Bob    | 76000   | 2             |
| 4           | Emily  | 76000   | 2             |
| 5           | Sam    | 75000   | 2             |

**Department**

| departmentId  | name       |
|---------------|------------|
| 1             | Sales      |
| 2             | Marketing  |

**The query would result in:**

| Department  | Employee  | Salary  |
|-------------|-----------|---------|
| Sales       | Jill      | 95000   |
| Marketing   | Bob       | 76000   |
| Marketing   | Emily     | 76000   |
