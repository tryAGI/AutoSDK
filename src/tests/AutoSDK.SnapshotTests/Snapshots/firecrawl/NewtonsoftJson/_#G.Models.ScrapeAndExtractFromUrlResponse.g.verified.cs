//HintName: G.Models.ScrapeAndExtractFromUrlResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScrapeAndExtractFromUrlResponse
    {
        /// <summary>
        /// Example: Payment required to access this resource.
        /// </summary>
        /// <example>Payment required to access this resource.</example>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeAndExtractFromUrlResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Example: Payment required to access this resource.
        /// </param>
        public ScrapeAndExtractFromUrlResponse(
            string? error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeAndExtractFromUrlResponse" /> class.
        /// </summary>
        public ScrapeAndExtractFromUrlResponse()
        {
        }
    }
}