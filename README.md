Reads through a given file and warns the user about lines exceeding 80 or a specified amount of characters.

To run the program do dotnet run and supply the filenames to be checked followed by the maximum amount of characters as an int (if you dont supply the max length, it will default to 80).

Example:

Dotnet run Program.cs README.cs eigthy.csproj 50

This will check the files Program.cs, README.cs & eigthy.csproj for lines exceeding the character length of 50.
