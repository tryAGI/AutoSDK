//HintName: G.Models.PostCliCreateSessionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostCliCreateSessionResponse
    {
        /// <summary>
        /// Unique identifier for the CLI session. UUID v4 format used for tracking and retrieval.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The 6-character hexadecimal code used for CLI login<br/>
        /// Example: ABC123
        /// </summary>
        /// <example>ABC123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The ISO timestamp when the session expires<br/>
        /// Example: 2023-01-01T12:00:00.000Z
        /// </summary>
        /// <example>2023-01-01T12:00:00.000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpiresAt { get; set; }

        /// <summary>
        /// The current status of the session<br/>
        /// Example: pending
        /// </summary>
        /// <example>pending</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostCliCreateSessionResponseStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostCliCreateSessionResponseStatus Status { get; set; }

        /// <summary>
        /// The key scope for this session<br/>
        /// Example: project
        /// </summary>
        /// <example>project</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostCliCreateSessionResponseScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostCliCreateSessionResponseScope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCliCreateSessionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the CLI session. UUID v4 format used for tracking and retrieval.
        /// </param>
        /// <param name="code">
        /// The 6-character hexadecimal code used for CLI login<br/>
        /// Example: ABC123
        /// </param>
        /// <param name="expiresAt">
        /// The ISO timestamp when the session expires<br/>
        /// Example: 2023-01-01T12:00:00.000Z
        /// </param>
        /// <param name="status">
        /// The current status of the session<br/>
        /// Example: pending
        /// </param>
        /// <param name="scope">
        /// The key scope for this session<br/>
        /// Example: project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostCliCreateSessionResponse(
            string id,
            string code,
            string expiresAt,
            global::G.PostCliCreateSessionResponseStatus status,
            global::G.PostCliCreateSessionResponseScope scope)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.ExpiresAt = expiresAt ?? throw new global::System.ArgumentNullException(nameof(expiresAt));
            this.Status = status;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostCliCreateSessionResponse" /> class.
        /// </summary>
        public PostCliCreateSessionResponse()
        {
        }
    }
}