# C# Code Challenges

## Challenge: [Unique Email Addresses](./UniqueEmailAddresses/)

Email addresses consist of a local-part and a domain name separated by the @ symbol.  In addition to numbers and lower case letters, the local-part may contain ‘.’s or ‘+’s.

When a period is placed between characters in the name, the email is delivered to the same address as if the periods were not included. For example an email sent to first.m.last@somewhere.com will be delivered to the same address as firstmlast@somewhere.com.

When a plus is placed in the local name, everything after the plus symbol will be ignored.  This would allow for additional filtering by the recipients.

These rules only apply to the local-part and do not apply to the domain name.  The domain name can consist of lowercase characters and the ‘.’ symbol.

- Given a list of email addresses, return the number of unique email addresses in C#.
 
Modify [`UniqueEmailAddresses`](./UniqueEmailAddresses/UniqueEmailAddresses.cs) to satisfy the above requirements.
You may provide tests within [`UniqueEmailAddressesTests`](./UniqueEmailAddresses.Tests/UniqueEmailAddressesTests.cs)

### Example

team1@somewhere.com , team.1+bob@somewhere.com and team1+jill+bob@somewhere.com would all go to the same email address.  team2@somewhere.com and team2@some.where.com would go to different addresses.

## Challenge: [Tic Tac Toe](./TicTacToe/)

Design a Tic-Tac-Toe game that can be played on an n x n grid by two players.

- It can be assumed that all inputs into the game will be valid modes.
- After a winning condition is reached, no more moves will be allowed.
- The winning condition is to place n pieces either horizontally, vertically or diagonally.

Implement [`ITicTacToe`](./TicTacToe/ITicTacToe.cs) to satisfy the above requirements. 
You may provide tests within [`TicTacToeTests`](./TicTacToe.Tests/TicTacToeTests.cs).
