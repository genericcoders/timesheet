Dragon
    This is the front-end Angular 2 application built for the timesheet application. It will rely on the Core project for back-end.

SETUP
-requires: Node and npm
    1. in directory, run npm install.
        a. /dragon/.gitignore lets you choose what files do not get committed to the
            repo. Make sure to not include node_modules and typings, as npm install 
            will automatically generate those folders
        b. In Windows, if you need to create a .gitignore file, create a file called
            ".gitignore." to by pass bullshit Windows file naming issues.

USING APPLICATION IN COMMAND LINE
-make sure to be navigated to the /timesheet/dragon folder
    1. npm start - runs the server