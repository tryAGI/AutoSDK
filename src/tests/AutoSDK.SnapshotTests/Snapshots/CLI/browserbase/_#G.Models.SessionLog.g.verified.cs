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
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PageId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        public global::G.SessionLogRequest? Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::G.SessionLogResponse? Response { get; set; }

        /// <summary>
        /// milliseconds that have elapsed since the UNIX epoch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frameId")]
        public string? FrameId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loaderId")]
        public string? LoaderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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