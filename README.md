# vrops_API_donwload_reports
C# application for working with vrops API

All static constants are defined in the file "Constants/RequestConstants.cs"
/file:Constants/RequestConstants.cs


On the vrops side, the following must be configured:
1. a read_only user (this needs to be changed)
2. a scheduled a report to be generated and ready to be downloaded


This app will do the following:
1. make the first get request to vrops restful API using the required headers
2. change dates to English and create current month and year variables
3. get the JSON response and parse it to dynamic data variable
4. inspect the json file and search for the requested report (in this case the last month report)
5. using regular expressions; define the report ID
6. make the second get request using the report ID to get the CSV file
7. create a datastream to save the response
8. write the response to a local file 


To-Do:
1. Authentication method changed to oAuth2
2. create a post request to generate the report (as a replacement of scheduled reports)
