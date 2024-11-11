//HintName: G.Models.CodespacesPublicKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The public key used for setting Codespaces secrets.
    /// </summary>
    public sealed partial class CodespacesPublicKey
    {
        /// <summary>
        /// The identifier for the key.<br/>
        /// Example: 1234567
        /// </summary>
        /// <example>1234567</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string KeyId { get; set; }

        /// <summary>
        /// The Base64 encoded public key.<br/>
        /// Example: hBT5WZEj8ZoOv6TYJsfWq7MxTEQopZO5/IT3ZCVQPzs=
        /// </summary>
        /// <example>hBT5WZEj8ZoOv6TYJsfWq7MxTEQopZO5/IT3ZCVQPzs=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Example: https://api.github.com/user/keys/2
        /// </summary>
        /// <example>https://api.github.com/user/keys/2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Example: ssh-rsa AAAAB3NzaC1yc2EAAA
        /// </summary>
        /// <example>ssh-rsa AAAAB3NzaC1yc2EAAA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Example: 2011-01-26T19:01:12Z
        /// </summary>
        /// <example>2011-01-26T19:01:12Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesPublicKey" /> class.
        /// </summary>
        /// <param name="keyId">
        /// The identifier for the key.<br/>
        /// Example: 1234567
        /// </param>
        /// <param name="key">
        /// The Base64 encoded public key.<br/>
        /// Example: hBT5WZEj8ZoOv6TYJsfWq7MxTEQopZO5/IT3ZCVQPzs=
        /// </param>
        /// <param name="id">
        /// Example: 2
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/user/keys/2
        /// </param>
        /// <param name="title">
        /// Example: ssh-rsa AAAAB3NzaC1yc2EAAA
        /// </param>
        /// <param name="createdAt">
        /// Example: 2011-01-26T19:01:12Z
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CodespacesPublicKey(
            string keyId,
            string key,
            int? id,
            string? url,
            string? title,
            string? createdAt)
        {
            this.KeyId = keyId ?? throw new global::System.ArgumentNullException(nameof(keyId));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Id = id;
            this.Url = url;
            this.Title = title;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodespacesPublicKey" /> class.
        /// </summary>
        public CodespacesPublicKey()
        {
        }
    }
}