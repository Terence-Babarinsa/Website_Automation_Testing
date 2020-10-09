# Website_Automation_Testing
Automation tests carried out on saucedemo.com using NUNit and SpecFlow within Visual Studio
# Project Overview
This project looks to test the fastest route for a customer to purchase an item on a website. It will test feature such as loggin in, selecting items, to checking out and providing the user with an overview of their order
# Class Diagram
<img src="ClassDiagram/Capture3.PNG" />

## Project review
The project was not too challenging in terms of creating the framework. There were alot of challenges in terms of creating POMs in terms of identifying elements on the webpage by id, classname or cssselector an d trying to avoiding using the xpath. The decision on the types of tests I carried out was based on simplicity on operation. Granted it was alot easier due to the lack of dependency of webpages on each other. This meant i didint have to transfer my driver between my POMs. 
## Project Retrospective
Successes of the project came in testing the majority of the purhasing process for the website. However, failure came forth as the entire functionality of the webiste was not tested due to time constraint
# How to use the framework
## Packages
- NUnit
- NUnitTest3Adapter
- Specflow
- Specflow.Chrome
## app.config
- create value key pair within app settings
- set the value to the url of the webpage you wish to test
## AppConfigReader
- create a static readonly property for the webpage(url) you wish to test
- assign the url from your 'app.config' class using the configuration manager

