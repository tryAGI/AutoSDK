//HintName: G.Models.ApiWebhooksInfoRetrieveResponseProjectDeleted.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiWebhooksInfoRetrieveResponseProjectDeleted
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization-only")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OrganizationOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiWebhooksInfoRetrieveResponseProjectDeleted" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <param name="organizationOnly"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ApiWebhooksInfoRetrieveResponseProjectDeleted(
            string description,
            string key,
            string name,
            bool organizationOnly)
        {
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OrganizationOnly = organizationOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiWebhooksInfoRetrieveResponseProjectDeleted" /> class.
        /// </summary>
        public ApiWebhooksInfoRetrieveResponseProjectDeleted()
        {
        }
    }
}