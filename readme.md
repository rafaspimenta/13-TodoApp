# Asp Net Web API + NGINX reverse proxy + frontend using javascript, html and css + containers

![image](https://github.com/rafaspimenta/TodoApp/assets/19673696/83464735-5ffc-40ca-8c9f-023d5c5d4379)


## This simple app is composed by:
- API: Controller-based ASP NET Web API
- NGINX reverse proxy
- Database: In-memory using EF Core
- Frontend: Javascript frontend using HTML and CSS
- Node express to host the frontend
- Dockerfiles and docker-compose to run the multiple container applications

## Start Web API
Go to the Todo.Api folder and execute the .NET Core command:
	
	dotnet run --launch https

## Start the JS frontend (port 5500)
Go to the Todo.Ui folder and execute the following commands:

	npm install
	node ./server.js

## API endpoints
	It can be taken from the swagger: https://localhost:[port]/swagger/index.html or the TodoApi.http file
 	port: consult launchSettings.json file


## Production mode
It will run the API in a nginx reverse proxy that will expose the port 80 and the frontend in the 5500 port.

	docker compose build
	docker compose up
