//HintName: G.Models.StreamingTaskRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StreamingTaskRequest
    {
        /// <summary>
        /// Example: &lt;session_id&gt;
        /// </summary>
        /// <example>&lt;session_id&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Example: Hey, there!
        /// </summary>
        /// <example>Hey, there!</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingTaskRequest" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// Example: &lt;session_id&gt;
        /// </param>
        /// <param name="text">
        /// Example: Hey, there!
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StreamingTaskRequest(
            string? sessionId,
            string? text)
        {
            this.SessionId = sessionId;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingTaskRequest" /> class.
        /// </summary>
        public StreamingTaskRequest()
        {
        }
    }
}