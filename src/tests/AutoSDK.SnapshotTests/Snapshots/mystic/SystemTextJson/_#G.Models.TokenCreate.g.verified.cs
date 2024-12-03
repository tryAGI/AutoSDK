//HintName: G.Models.TokenCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model for creating an API token
    /// </summary>
    public sealed partial class TokenCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCreate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="expiresAt"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TokenCreate(
            string? name,
            global::System.DateTime? expiresAt)
        {
            this.Name = name;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCreate" /> class.
        /// </summary>
        public TokenCreate()
        {
        }
    }
}