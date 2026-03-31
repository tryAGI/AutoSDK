//HintName: G.Models.ListResourceClientKeysResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListResourceClientKeysResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedDomains { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_id")]
        public string? ResourceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResourceClientKeysResponseItem" /> class.
        /// </summary>
        /// <param name="clientKey"></param>
        /// <param name="allowedDomains"></param>
        /// <param name="name"></param>
        /// <param name="resourceId"></param>
        /// <param name="createdAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListResourceClientKeysResponseItem(
            string clientKey,
            global::System.Collections.Generic.IList<string> allowedDomains,
            string? name,
            string? resourceId,
            string? createdAt)
        {
            this.ClientKey = clientKey ?? throw new global::System.ArgumentNullException(nameof(clientKey));
            this.AllowedDomains = allowedDomains ?? throw new global::System.ArgumentNullException(nameof(allowedDomains));
            this.Name = name;
            this.ResourceId = resourceId;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResourceClientKeysResponseItem" /> class.
        /// </summary>
        public ListResourceClientKeysResponseItem()
        {
        }
    }
}