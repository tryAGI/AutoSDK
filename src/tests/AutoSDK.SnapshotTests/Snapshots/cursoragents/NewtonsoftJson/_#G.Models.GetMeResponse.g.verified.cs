//HintName: G.Models.GetMeResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetMeResponse
    {
        /// <summary>
        /// The name of the API key<br/>
        /// Example: Production API Key
        /// </summary>
        /// <example>Production API Key</example>
        [global::Newtonsoft.Json.JsonProperty("apiKeyName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ApiKeyName { get; set; } = default!;

        /// <summary>
        /// When the API key was created<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Email address of the user who owns the API key (if available)<br/>
        /// Example: developer@example.com
        /// </summary>
        /// <example>developer@example.com</example>
        [global::Newtonsoft.Json.JsonProperty("userEmail")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMeResponse" /> class.
        /// </summary>
        /// <param name="apiKeyName">
        /// The name of the API key<br/>
        /// Example: Production API Key
        /// </param>
        /// <param name="createdAt">
        /// When the API key was created<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
        /// <param name="userEmail">
        /// Email address of the user who owns the API key (if available)<br/>
        /// Example: developer@example.com
        /// </param>
        public GetMeResponse(
            string apiKeyName,
            global::System.DateTime createdAt,
            string? userEmail)
        {
            this.ApiKeyName = apiKeyName ?? throw new global::System.ArgumentNullException(nameof(apiKeyName));
            this.CreatedAt = createdAt;
            this.UserEmail = userEmail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMeResponse" /> class.
        /// </summary>
        public GetMeResponse()
        {
        }
    }
}