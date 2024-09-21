//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the API definition for Ideogram AI.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


        /// <summary>
        /// All things related to generating content.
        /// </summary>
        public GenerateClient Generate { get; }

        /// <summary>
        /// Content related to managing API account and API access
        /// </summary>
        public ManageClient Manage { get; }

        /// <summary>
        /// Operations related to understanding visual content
        /// </summary>
        public VisionClient Vision { get; }

    }
}