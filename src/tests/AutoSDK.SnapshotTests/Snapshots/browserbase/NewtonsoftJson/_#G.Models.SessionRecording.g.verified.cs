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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public object Data { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionId { get; set; } = default!;

        /// <summary>
        /// milliseconds that have elapsed since the UNIX epoch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public long Timestamp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public int Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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