//HintName: G.Models.SessionLog.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SessionLog
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method", Required = global::Newtonsoft.Json.Required.Always)]
        public string Method { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pageId", Required = global::Newtonsoft.Json.Required.Always)]
        public int PageId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sessionId", Required = global::Newtonsoft.Json.Required.Always)]
        public string SessionId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request")]
        public global::G.SessionLogRequest? Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response")]
        public global::G.SessionLogResponse? Response { get; set; }

        /// <summary>
        /// milliseconds that have elapsed since the UNIX epoch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frameId")]
        public string? FrameId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("loaderId")]
        public string? LoaderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionLog" /> class.
        /// </summary>
        /// <param name="method"></param>
        /// <param name="pageId"></param>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="response"></param>
        /// <param name="timestamp">
        /// milliseconds that have elapsed since the UNIX epoch
        /// </param>
        /// <param name="frameId"></param>
        /// <param name="loaderId"></param>
        public SessionLog(
            string method,
            int pageId,
            string sessionId,
            global::G.SessionLogRequest? request,
            global::G.SessionLogResponse? response,
            long? timestamp,
            string? frameId,
            string? loaderId)
        {
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
            this.PageId = pageId;
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Request = request;
            this.Response = response;
            this.Timestamp = timestamp;
            this.FrameId = frameId;
            this.LoaderId = loaderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionLog" /> class.
        /// </summary>
        public SessionLog()
        {
        }
    }
}