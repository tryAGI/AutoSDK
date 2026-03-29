//HintName: G.Models.SearchAndScrapeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchAndScrapeResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("success")]
        public bool? Success { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.SearchAndScrapeResponseDataItem>? Data { get; set; }

        /// <summary>
        /// Warning message if any issues occurred
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("warning")]
        public string? Warning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAndScrapeResponse" /> class.
        /// </summary>
        /// <param name="success"></param>
        /// <param name="data"></param>
        /// <param name="warning">
        /// Warning message if any issues occurred
        /// </param>
        public SearchAndScrapeResponse(
            bool? success,
            global::System.Collections.Generic.IList<global::G.SearchAndScrapeResponseDataItem>? data,
            string? warning)
        {
            this.Success = success;
            this.Data = data;
            this.Warning = warning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAndScrapeResponse" /> class.
        /// </summary>
        public SearchAndScrapeResponse()
        {
        }
    }
}