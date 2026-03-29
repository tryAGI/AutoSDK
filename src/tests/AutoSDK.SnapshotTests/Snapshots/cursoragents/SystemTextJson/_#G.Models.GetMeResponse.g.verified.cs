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
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKeyName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyName { get; set; }

        /// <summary>
        /// When the API key was created<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Email address of the user who owns the API key (if available)<br/>
        /// Example: developer@example.com
        /// </summary>
        /// <example>developer@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("userEmail")]
        public string? UserEmail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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