//HintName: G.Models.GetDeepResearchStatusResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDeepResearchStatusResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finalAnalysis")]
        public string? FinalAnalysis { get; set; }

        /// <summary>
        /// Displayed when using JSON format
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("json")]
        public object? Json { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("activities")]
        public global::System.Collections.Generic.IList<global::G.GetDeepResearchStatusResponseDataActivitie>? Activities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sources")]
        public global::System.Collections.Generic.IList<global::G.GetDeepResearchStatusResponseDataSource>? Sources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GetDeepResearchStatusResponseDataStatusJsonConverter))]
        public global::G.GetDeepResearchStatusResponseDataStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error")]
        public string? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currentDepth")]
        public int? CurrentDepth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxDepth")]
        public int? MaxDepth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalUrls")]
        public int? TotalUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeepResearchStatusResponseData" /> class.
        /// </summary>
        /// <param name="finalAnalysis"></param>
        /// <param name="json">
        /// Displayed when using JSON format
        /// </param>
        /// <param name="activities"></param>
        /// <param name="sources"></param>
        /// <param name="status"></param>
        /// <param name="error"></param>
        /// <param name="expiresAt"></param>
        /// <param name="currentDepth"></param>
        /// <param name="maxDepth"></param>
        /// <param name="totalUrls"></param>
        public GetDeepResearchStatusResponseData(
            string? finalAnalysis,
            object? json,
            global::System.Collections.Generic.IList<global::G.GetDeepResearchStatusResponseDataActivitie>? activities,
            global::System.Collections.Generic.IList<global::G.GetDeepResearchStatusResponseDataSource>? sources,
            global::G.GetDeepResearchStatusResponseDataStatus? status,
            string? error,
            global::System.DateTime? expiresAt,
            int? currentDepth,
            int? maxDepth,
            int? totalUrls)
        {
            this.FinalAnalysis = finalAnalysis;
            this.Json = json;
            this.Activities = activities;
            this.Sources = sources;
            this.Status = status;
            this.Error = error;
            this.ExpiresAt = expiresAt;
            this.CurrentDepth = currentDepth;
            this.MaxDepth = maxDepth;
            this.TotalUrls = totalUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDeepResearchStatusResponseData" /> class.
        /// </summary>
        public GetDeepResearchStatusResponseData()
        {
        }
    }
}