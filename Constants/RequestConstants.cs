namespace RESTfulAPIConsume.Constants
{
    public static class RequestConstants
    {
        public const string BaseUrl = "https://vrops";
        public const string UrlPublic = "https://vrops/suite-api/doc/v2/api-docs?group=Public%20APIs";
        public const string UrlGetReport = "https://vrops/suite-api/api/reports";
        public const string APIUrl = "https://vrops/suite-api/api";
        public const string ReportDefinitionId = "fed8c884-1c8a-4bc3-9c22-058f5cb53b14";
        public const string UrlGetReportDefinitionId = APIUrl + "/reportdefinitions/" + ReportDefinitionId + "/schedules";
        public const string path = @"D:\example_location\vrops_API_donwload_reports\downloads\report.csv";
        public const string usernName = "user";
        public const string password = "password";
        // authorization header format is "username:password"
        public const string auth = usernName + ":" + password;
        public const string UserAgent = "User-Agent";
        public const string UserAgentValue = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.36";
    }
}