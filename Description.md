## Problem
Develop an interactive command line application using the provided solution file. You must read in data from both of the given JSON files (located in the Data folder) meeting the following criteria:

The application must contain the following commands at minimum. Note, we have provided the command line parser and included the exit command. We have stubs for most of the other required commands:

| Command 									| Description
|---											|---
| exit										| Exits the application
| help										| Displays all available commands
| list										| Displays all of the data contained in the loaded file
| searchby <field> <searchString> 	| Searches the loaded file on the given <field> and displays all rows matching any part of the <searchString> in that field. Passing no parameters to this command displays all available fields of the selected file.
| load <path>								| Loads the json data to view. Passing no parameters to this command shows the available files to view.

#### Notes
- Helpful to think of the files as data from a database table. 
- You must use JSON.NET (provided in .sln) to read in each JSON file.
- No additional libraries should be used except what is provided in the solution.
- Feel free to add to or alter the code as you deem necessary with any additional functionality, parameters, or commands

**Send back a zipped file with all source code and a .sln file before your scheduled technical interview for review.**

## Evaluation Criteria
- Your program must run and at minimum use the commands above
- We are not concerned about pretty printing the outputs (opt to spend less time on formatting and more on functionality)
- Expect to be questioned on your design choices
