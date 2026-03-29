//HintName: G.Models.ApiWebhooksInfoRetrieveResponseAnnotationUpdated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ApiWebhooksInfoRetrieveResponseAnnotationUpdated
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization-only", Required = global::Newtonsoft.Json.Required.Always)]
        public bool OrganizationOnly { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiWebhooksInfoRetrieveResponseAnnotationUpdated" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="key"></param>
        /// <param name="name"></param>
        /// <param name="organizationOnly"></param>
        public ApiWebhooksInfoRetrieveResponseAnnotationUpdated(
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
        /// Initializes a new instance of the <see cref="ApiWebhooksInfoRetrieveResponseAnnotationUpdated" /> class.
        /// </summary>
        public ApiWebhooksInfoRetrieveResponseAnnotationUpdated()
        {
        }
    }
}