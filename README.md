# MySql-SqLite_WPF_App
Application with MySql and SqLite databases in use at same time (WPF app, MVVM architecture, code-first EntityFramework)

In order to run it on your machine - you need to:
- Have an instance of MySql server with an empty database;
- Modify the MySql and SqLite connection strings (App.config, rows 24, 25) with your server values;
- In Package Manager Console run command: Update-Database .
