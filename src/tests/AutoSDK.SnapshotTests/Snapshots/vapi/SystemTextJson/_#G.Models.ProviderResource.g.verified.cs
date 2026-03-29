//HintName: G.Models.ProviderResource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProviderResource
    {
        /// <summary>
        /// This is the unique identifier for the provider resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// This is the unique identifier for the org that this provider resource belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the provider resource was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// This is the ISO 8601 date-time string of when the provider resource was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updatedAt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// This is the provider that manages this resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProviderResourceProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProviderResourceProvider Provider { get; set; }

        /// <summary>
        /// This is the name/type of the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceName")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProviderResourceResourceNameJsonConverter))]
        public global::G.ProviderResourceResourceName ResourceName { get; set; }

        /// <summary>
        /// This is the provider-specific identifier for the resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resourceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceId { get; set; }

        /// <summary>
        /// This is the full resource data from the provider's API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Resource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderResource" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the provider resource.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the org that this provider resource belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the provider resource was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the provider resource was last updated.
        /// </param>
        /// <param name="provider">
        /// This is the provider that manages this resource.
        /// </param>
        /// <param name="resourceId">
        /// This is the provider-specific identifier for the resource.
        /// </param>
        /// <param name="resource">
        /// This is the full resource data from the provider's API.
        /// </param>
        /// <param name="resourceName">
        /// This is the name/type of the resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProviderResource(
            string id,
            string orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::G.ProviderResourceProvider provider,
            string resourceId,
            object resource,
            global::G.ProviderResourceResourceName resourceName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Provider = provider;
            this.ResourceName = resourceName;
            this.ResourceId = resourceId ?? throw new global::System.ArgumentNullException(nameof(resourceId));
            this.Resource = resource ?? throw new global::System.ArgumentNullException(nameof(resource));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProviderResource" /> class.
        /// </summary>
        public ProviderResource()
        {
        }
    }
}