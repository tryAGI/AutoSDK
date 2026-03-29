//HintName: G.Models.ResourceMeta.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResourceMeta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resourceType", Required = global::Newtonsoft.Json.Required.Always)]
        public string ResourceType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location", Required = global::Newtonsoft.Json.Required.Always)]
        public string Location { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceMeta" /> class.
        /// </summary>
        /// <param name="resourceType"></param>
        /// <param name="location"></param>
        public ResourceMeta(
            string resourceType,
            string location)
        {
            this.ResourceType = resourceType ?? throw new global::System.ArgumentNullException(nameof(resourceType));
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceMeta" /> class.
        /// </summary>
        public ResourceMeta()
        {
        }
    }
}