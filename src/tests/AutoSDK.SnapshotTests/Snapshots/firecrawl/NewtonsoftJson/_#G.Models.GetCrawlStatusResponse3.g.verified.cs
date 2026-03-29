//HintName: G.Models.GetCrawlStatusResponse3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCrawlStatusResponse3
    {
        /// <summary>
        /// Example: An unexpected error occurred on the server.
        /// </summary>
        /// <example>An unexpected error occurred on the server.</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCrawlStatusResponse3" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: An unexpected error occurred on the server.
        /// </param>
        public GetCrawlStatusResponse3(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCrawlStatusResponse3" /> class.
        /// </summary>
        public GetCrawlStatusResponse3()
        {
        }
    }
}