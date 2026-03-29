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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The 6-character hexadecimal code used for CLI login<br/>
        /// Example: ABC123
        /// </summary>
        /// <example>ABC123</example>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// The ISO timestamp when the session expires<br/>
        /// Example: 2023-01-01T12:00:00.000Z
        /// </summary>
        /// <example>2023-01-01T12:00:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("expiresAt", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExpiresAt { get; set; } = default!;

        /// <summary>
        /// The current status of the session<br/>
        /// Example: pending
        /// </summary>
        /// <example>pending</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostCliCreateSessionResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// The key scope for this session<br/>
        /// Example: project
        /// </summary>
        /// <example>project</example>
        [global::Newtonsoft.Json.JsonProperty("scope", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostCliCreateSessionResponseScope Scope { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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