//HintName: G.Models.GetScoresResponseTraceData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetScoresResponseTraceData
    {
        /// <summary>
        /// The user ID associated with the trace referenced by score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// A list of tags associated with the trace referenced by score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// The environment of the trace referenced by score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// The session ID associated with the trace referenced by score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionId")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseTraceData" /> class.
        /// </summary>
        /// <param name="userId">
        /// The user ID associated with the trace referenced by score
        /// </param>
        /// <param name="tags">
        /// A list of tags associated with the trace referenced by score
        /// </param>
        /// <param name="environment">
        /// The environment of the trace referenced by score
        /// </param>
        /// <param name="sessionId">
        /// The session ID associated with the trace referenced by score
        /// </param>
        public GetScoresResponseTraceData(
            string? userId,
            global::System.Collections.Generic.IList<string>? tags,
            string? environment,
            string? sessionId)
        {
            this.UserId = userId;
            this.Tags = tags;
            this.Environment = environment;
            this.SessionId = sessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetScoresResponseTraceData" /> class.
        /// </summary>
        public GetScoresResponseTraceData()
        {
        }
    }
}