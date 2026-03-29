//HintName: G.Models.CreatedAccessToken.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreatedAccessToken
    {
        /// <summary>
        /// Identifier of the access token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Name of the access token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The fully created access token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.IdentifierMaskingDetails Mask { get; set; }

        /// <summary>
        /// Timestamp of access token creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedAccessToken" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier of the access token
        /// </param>
        /// <param name="name">
        /// Name of the access token
        /// </param>
        /// <param name="token">
        /// The fully created access token
        /// </param>
        /// <param name="mask"></param>
        /// <param name="createdAt">
        /// Timestamp of access token creation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreatedAccessToken(
            global::System.Guid id,
            string name,
            string token,
            global::G.IdentifierMaskingDetails mask,
            global::System.DateTime createdAt)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Token = token ?? throw new global::System.ArgumentNullException(nameof(token));
            this.Mask = mask ?? throw new global::System.ArgumentNullException(nameof(mask));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreatedAccessToken" /> class.
        /// </summary>
        public CreatedAccessToken()
        {
        }
    }
}