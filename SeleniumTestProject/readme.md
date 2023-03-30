## **Automated UI Testing - C# Final Project **

#@ Pre-Requirements Prior To Testing
- Please copy the pants.txt file from the SeleniumTestProject solution folder to the desktop in order for the file upload test to work!
- All of the tests uses xUnit, Selenium, Selenium Web Driver(that includes the Chrome Driver), and Fluent Assertions.
- If these are not included in the solution folder, please install them from the Nuget Package Manager.

- All of the tests are within the "Tests" folder, as the Page Object Models are within the "PageObjectModels" folder.

## Final Project Objectives 
Create a suite of automated UI tests for publicly accessible web applications. You may use any online web application you choose, and you are not required to write all of your tests against the same application. You may write your tests in the same project as your API tests from the midterm, or you may create a new one. You may use any Nuget packages, test frameworks, or assertion libraries you choose, but your solution must be in C#. Create at least 15 automated UI tests. Your tests should each be unique and test a different use case of the web application. Your tests should also cover all of the following criteria:

- [x] 1. Each test must contain an assertion.

- [x] 2. Include at least 1 negative test.

- [x] 3. Include at least one test for each of the following complex page controls: 

- [x] - A file upload

- [x] - A date picker

- [x] - A hover-over or tooltip

- [x] 4. Include at least one test that performs an action that opens a new tab or window, and then continues the test in that new tab or window.

- [x] 5. Utilize a Page Object Model. Create at least 3 Page Object Model classes that represent web pages under test.

Ensure that at the end of your tests, any and all open browser windows or sessions are closed and disposed of properly.

Build your code and run your tests. All tests should run and all assertions should pass in order to receive credit. If your code requires any setup in order to build or run your tests, include a readme file with instructions to build and run your code. Check your completed tests into a GitHub repository, and submit that link as your turn-in.