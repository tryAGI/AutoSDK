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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the org that this provider resource belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrgId { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the provider resource was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the provider resource was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// This is the provider that manages this resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProviderResourceProviderJsonConverter))]
        public global::G.ProviderResourceProvider Provider { get; set; } = default!;

        /// <summary>
        /// This is the name/type of the resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceName")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProviderResourceResourceNameJsonConverter))]
        public global::G.ProviderResourceResourceName ResourceName { get; set; }

        /// <summary>
        /// This is the provider-specific identifier for the resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceId", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResourceId { get; set; } = default!;

        /// <summary>
        /// This is the full resource data from the provider's API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resource", Required = global::Newtonsoft.Json.Required.Always)]
        public object Resource { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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