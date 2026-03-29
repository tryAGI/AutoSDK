//HintName: G.Models.SessionRecording.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionRecording
    {
        /// <summary>
        /// See [rrweb documentation](https://github.com/rrweb-io/rrweb/blob/master/docs/recipes/dive-into-event.md).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// milliseconds that have elapsed since the UNIX epoch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRecording" /> class.
        /// </summary>
        /// <param name="data">
        /// See [rrweb documentation](https://github.com/rrweb-io/rrweb/blob/master/docs/recipes/dive-into-event.md).
        /// </param>
        /// <param name="sessionId"></param>
        /// <param name="timestamp">
        /// milliseconds that have elapsed since the UNIX epoch
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionRecording(
            object data,
            string sessionId,
            long timestamp,
            int type)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Timestamp = timestamp;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRecording" /> class.
        /// </summary>
        public SessionRecording()
        {
        }
    }
}