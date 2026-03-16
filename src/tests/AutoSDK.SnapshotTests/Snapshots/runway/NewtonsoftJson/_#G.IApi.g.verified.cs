//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The API makes generative AI models available, at the same credits prices listed here ($0.01 per credit): https://help.runwayml.com/hc/en-us/articles/15124877443219-How-do-credits-work<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


        /// <summary>
        /// These endpoints all kick off tasks to create generations.
        /// </summary>
        public StartGeneratingClient StartGenerating { get; }

        /// <summary>
        /// Endpoints for managing tasks that have been submitted.
        /// </summary>
        public TaskManagementClient TaskManagement { get; }

        /// <summary>
        /// Endpoints for uploading media files.
        /// </summary>
        public UploadsClient Uploads { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrganizationClient Organization { get; }

    }
}