//HintName: G.Models.BodyDeleteRunsApiV1RunsDeletePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyDeleteRunsApiV1RunsDeletePost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("session_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid SessionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::System.Guid> TraceIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteRunsApiV1RunsDeletePost" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="traceIds"></param>
        public BodyDeleteRunsApiV1RunsDeletePost(
            global::System.Guid sessionId,
            global::System.Collections.Generic.IList<global::System.Guid> traceIds)
        {
            this.SessionId = sessionId;
            this.TraceIds = traceIds ?? throw new global::System.ArgumentNullException(nameof(traceIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteRunsApiV1RunsDeletePost" /> class.
        /// </summary>
        public BodyDeleteRunsApiV1RunsDeletePost()
        {
        }
    }
}