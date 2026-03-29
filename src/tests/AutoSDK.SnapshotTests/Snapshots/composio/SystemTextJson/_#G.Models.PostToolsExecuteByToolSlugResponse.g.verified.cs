//HintName: G.Models.PostToolsExecuteByToolSlugResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostToolsExecuteByToolSlugResponse
    {
        /// <summary>
        /// Tool execution output data that varies based on the specific tool<br/>
        /// Example: {"run_id":12345678,"status":"queued","created_at":"2023-01-01T12:00:00Z","html_url":"https://github.com/octocat/Hello-World/actions/runs/12345678"}
        /// </summary>
        /// <example>{"run_id":12345678,"status":"queued","created_at":"2023-01-01T12:00:00Z","html_url":"https://github.com/octocat/Hello-World/actions/runs/12345678"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, object?> Data { get; set; }

        /// <summary>
        /// Error message if the tool execution was not successful (null if successful)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Indicates if the tool execution was successful<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Successful { get; set; }

        /// <summary>
        /// Optional session information for tools that return session context<br/>
        /// Example: {"session_id":"session-12345","expires_at":"2023-01-01T13:00:00Z"}
        /// </summary>
        /// <example>{"session_id":"session-12345","expires_at":"2023-01-01T13:00:00Z"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_info")]
        public object? SessionInfo { get; set; }

        /// <summary>
        /// Unique identifier for the execution log (useful for debugging and support)<br/>
        /// Example: log_abc123def456
        /// </summary>
        /// <example>log_abc123def456</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("log_id")]
        public string? LogId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteByToolSlugResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Tool execution output data that varies based on the specific tool<br/>
        /// Example: {"run_id":12345678,"status":"queued","created_at":"2023-01-01T12:00:00Z","html_url":"https://github.com/octocat/Hello-World/actions/runs/12345678"}
        /// </param>
        /// <param name="successful">
        /// Indicates if the tool execution was successful<br/>
        /// Example: true
        /// </param>
        /// <param name="error">
        /// Error message if the tool execution was not successful (null if successful)
        /// </param>
        /// <param name="sessionInfo">
        /// Optional session information for tools that return session context<br/>
        /// Example: {"session_id":"session-12345","expires_at":"2023-01-01T13:00:00Z"}
        /// </param>
        /// <param name="logId">
        /// Unique identifier for the execution log (useful for debugging and support)<br/>
        /// Example: log_abc123def456
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostToolsExecuteByToolSlugResponse(
            global::System.Collections.Generic.Dictionary<string, object?> data,
            bool successful,
            string? error,
            object? sessionInfo,
            string? logId)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Error = error;
            this.Successful = successful;
            this.SessionInfo = sessionInfo;
            this.LogId = logId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostToolsExecuteByToolSlugResponse" /> class.
        /// </summary>
        public PostToolsExecuteByToolSlugResponse()
        {
        }
    }
}