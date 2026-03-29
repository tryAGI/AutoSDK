//HintName: G.Models.GetAnalyticsSummaryCacheResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsSummaryCacheResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetAnalyticsSummaryCacheResponseSummary Summary { get; set; } = default!;

        /// <summary>
        /// The type of object being returned
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.GetAnalyticsSummaryCacheResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsSummaryCacheResponse" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="object">
        /// The type of object being returned
        /// </param>
        public GetAnalyticsSummaryCacheResponse(
            global::G.GetAnalyticsSummaryCacheResponseSummary summary,
            global::G.GetAnalyticsSummaryCacheResponseObject @object)
        {
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsSummaryCacheResponse" /> class.
        /// </summary>
        public GetAnalyticsSummaryCacheResponse()
        {
        }
    }
}