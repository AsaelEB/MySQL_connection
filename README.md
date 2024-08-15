# MySQL_connection
This is an independient project, qhere I'm learning a bit more about C# and MySQL.

The program creates a connection to a database, then modifies or reads a table from a database. The database and table where previously created using XAMPP and MySQL.
In this case, the database 'users' contains a table called 'user' where a UserID and UserName are stored. 

The program has 2 functions:
- insert(): Asks for the ID and Name for the new user and adds them to the table on the database. I think this function can be upgraded to read the SQL command from the user too.
  
- read(): Executes the query `SELECT * FROM user` and displays the information on screen, with a specific format. The function waits before closing the programm using ReadLine().

The program was created using Visual Studio 15 on C# language, the database was created with MySQL on XAMPP
