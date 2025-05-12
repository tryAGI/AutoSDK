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
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> TraceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteRunsApiV1RunsDeletePost" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="traceIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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