//HintName: G.Models.ApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiKey
    {
        /// <summary>
        /// Example: vYV8OdUMRzRQbzpp2JzY5DvriBnuVHo3pYpPQ7IJWyw=
        /// </summary>
        /// <example>vYV8OdUMRzRQbzpp2JzY5DvriBnuVHo3pYpPQ7IJWyw=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiKey")]
        public string? ApiKey1 { get; set; }

        /// <summary>
        /// Example: 50e19a35ee1df775c09628dade1c00f0f680c6e15256e34a6eab350b38b31352df35c4db7925a3e5dd41cc773a0e2529e6c6da18408a8bbeeb0ae4b0f0ab9486.a96478a9225ed6ab
        /// </summary>
        /// <example>50e19a35ee1df775c09628dade1c00f0f680c6e15256e34a6eab350b38b31352df35c4db7925a3e5dd41cc773a0e2529e6c6da18408a8bbeeb0ae4b0f0ab9486.a96478a9225ed6ab</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("apiSecret")]
        public string? ApiSecret { get; set; }

        /// <summary>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("chatFlows")]
        public byte[]? ChatFlows { get; set; }

        /// <summary>
        /// Example: 10-Mar-24
        /// </summary>
        /// <example>10-Mar-24</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Example: 525e4daa2104f06ffdea5c1af37009be
        /// </summary>
        /// <example>525e4daa2104f06ffdea5c1af37009be</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Example: someKeyName
        /// </summary>
        /// <example>someKeyName</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyName")]
        public string? KeyName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        /// <param name="apiKey1">
        /// Example: vYV8OdUMRzRQbzpp2JzY5DvriBnuVHo3pYpPQ7IJWyw=
        /// </param>
        /// <param name="apiSecret">
        /// Example: 50e19a35ee1df775c09628dade1c00f0f680c6e15256e34a6eab350b38b31352df35c4db7925a3e5dd41cc773a0e2529e6c6da18408a8bbeeb0ae4b0f0ab9486.a96478a9225ed6ab
        /// </param>
        /// <param name="chatFlows">
        /// Example: []
        /// </param>
        /// <param name="createdAt">
        /// Example: 10-Mar-24
        /// </param>
        /// <param name="id">
        /// Example: 525e4daa2104f06ffdea5c1af37009be
        /// </param>
        /// <param name="keyName">
        /// Example: someKeyName
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiKey(
            string? apiKey1,
            string? apiSecret,
            byte[]? chatFlows,
            string? createdAt,
            string? id,
            string? keyName)
        {
            this.ApiKey1 = apiKey1;
            this.ApiSecret = apiSecret;
            this.ChatFlows = chatFlows;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.KeyName = keyName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        public ApiKey()
        {
        }
    }
}