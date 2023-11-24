# Asp Net Web API + NGINX reverse proxy + Simple frontend using javascript, html and css

## This simple app is composed by:
- Controller-based web API
- In memory database
- Javascript frontend using html and css

## Start Web API
You should go to the root folder and execute the .NET Core command line:
	
	dotnet run --launch https

## Start the JS frontend
	Open the index.html from the Todo.UI folder using the live server extension from VS Code

## API endpoints
	It can be taken from the swagger: https://localhost:[port]/swagger/index.html or the TodoApi.http file
 	port: consult launchSettings.json file


## Production mode
It will run the API in a nginx reverse proxy that will expose the port 80.

	docker compose up
