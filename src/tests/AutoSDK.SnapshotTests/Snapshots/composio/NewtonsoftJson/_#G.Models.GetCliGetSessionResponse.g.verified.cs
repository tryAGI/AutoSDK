//HintName: G.Models.GetCliGetSessionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetCliGetSessionResponse
    {
        /// <summary>
        /// The unique identifier for the CLI session<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
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
        /// The current status of the session<br/>
        /// Example: pending
        /// </summary>
        /// <example>pending</example>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetCliGetSessionResponseStatus Status { get; set; } = default!;

        /// <summary>
        /// The ISO timestamp when the session expires<br/>
        /// Example: 2023-01-01T12:00:00.000Z
        /// </summary>
        /// <example>2023-01-01T12:00:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("expiresAt", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExpiresAt { get; set; } = default!;

        /// <summary>
        /// Information about the linked account, if any. Null if the session status is "pending".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account")]
        public global::G.GetCliGetSessionResponseAccount? Account { get; set; }

        /// <summary>
        /// The API key for the linked account<br/>
        /// Example: 1234567890
        /// </summary>
        /// <example>1234567890</example>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// The key scope for this session<br/>
        /// Example: project
        /// </summary>
        /// <example>project</example>
        [global::Newtonsoft.Json.JsonProperty("scope")]
        public global::G.GetCliGetSessionResponseScope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCliGetSessionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier for the CLI session<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
        /// <param name="code">
        /// The 6-character hexadecimal code used for CLI login<br/>
        /// Example: ABC123
        /// </param>
        /// <param name="status">
        /// The current status of the session<br/>
        /// Example: pending
        /// </param>
        /// <param name="expiresAt">
        /// The ISO timestamp when the session expires<br/>
        /// Example: 2023-01-01T12:00:00.000Z
        /// </param>
        /// <param name="account">
        /// Information about the linked account, if any. Null if the session status is "pending".
        /// </param>
        /// <param name="apiKey">
        /// The API key for the linked account<br/>
        /// Example: 1234567890
        /// </param>
        /// <param name="scope">
        /// The key scope for this session<br/>
        /// Example: project
        /// </param>
        public GetCliGetSessionResponse(
            string id,
            string code,
            global::G.GetCliGetSessionResponseStatus status,
            string expiresAt,
            global::G.GetCliGetSessionResponseAccount? account,
            string? apiKey,
            global::G.GetCliGetSessionResponseScope? scope)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Status = status;
            this.ExpiresAt = expiresAt ?? throw new global::System.ArgumentNullException(nameof(expiresAt));
            this.Account = account;
            this.ApiKey = apiKey;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetCliGetSessionResponse" /> class.
        /// </summary>
        public GetCliGetSessionResponse()
        {
        }
    }
}