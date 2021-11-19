I. Pre-requisites
	1. IIS Express
	2. Visual Studio 2019 or later
	3. .Net Core 5.0 SDK

II. Overview

For this API, I am utilizing Entity Framework Core In-memory database for the data store.
I am using the CQRS pattern implemented using MediatR.
I used CQRS to allow the application to be maintainable, scalable, and performant.

This pattern allows a developer to perform different queries regardless of what our data transfer objects is like. Having the ability to have different structures for our read and write object simplifies object mapping when performing read operations and simplifies validations that may be needed for the write actions. 

Having the commands and queries isolated allows for more granular scaling and optimizations.
Using this pattern allows for designing for more simpler queries.

III. Perform the following steps to run the WebApi:
	1. Open the Exam.Application.WebApi.sln file using Visual Studio
	2. Build the solution to restore Nuget Packages
	3. Click on the Debug button to run the solution
	4. A message will pop up saying "This project is configured to use SSL. To avoid SSL warnings in the browser you can choose to trust the self-signed certificate that IIS Express has generated. Would you like to trust the IIS Express SSL certificate"
For simplicity, click Yes. 

	5. Select Yes for the pop-up to install the certificate.
	6. The solution should build, run and open swagger in your default web browser.

IV. Data Creation:
	A. To create data
		1. Expand the Post section
		2. Click Try it out. Under Request body, modify the json as needed.
		3. Click Execute.
		4. Return will be 200 on successful creation.

	B.To retrieve all data
		1. Expand the Get section
	2. Click Try it out. Click on Execute to display all items found in the data store

IV. Solution
The projects have been created with the following intentions:

	1. Exam.Application.WebApi.Host - Starting project. The controller endpoint are defined here.

	2. Exam.Application.WebApi.Domain - The business entities are defined here.

	3. Exam.Application.WebApi.Application - The commands and queries are defined here which describes the tasks specific for the application.

	4. Exam.Application.WebApi.Infrastructure - The data store/dbContext is defined here.

	5. Exam.Application.WebApi.Tests - To contain the unit tests/functional tests. Apologies, ran out of time and unable to provide tests.