# vrops_API_donwload_reports
C# application for working with vrops API

all static constants are defined in the file "https://github.com/karam-ajaj/vrops_API_donwload_reports/blob/22fe550baf5878160617844aacf6b3220859b67b/Constants/RequestConstants.cs"


on the vrops side, the following must be configured:
1. a red_only user (this needs to be changed)
2. a scheduled a report to be generated and ready to be downloaded


this app will do the following:
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
