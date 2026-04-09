//HintName: G.Models.CancelCrawlResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CancelCrawlResponse
    {
        /// <summary>
        /// Example: cancelled
        /// </summary>
        /// <example>cancelled</example>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CancelCrawlResponseStatusJsonConverter))]
        public global::G.CancelCrawlResponseStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelCrawlResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// Example: cancelled
        /// </param>
        public CancelCrawlResponse(
            global::G.CancelCrawlResponseStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancelCrawlResponse" /> class.
        /// </summary>
        public CancelCrawlResponse()
        {
        }
    }
}