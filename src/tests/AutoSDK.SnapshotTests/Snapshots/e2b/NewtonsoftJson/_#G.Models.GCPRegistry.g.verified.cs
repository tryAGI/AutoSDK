//HintName: G.Models.GCPRegistry.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GCPRegistry
    {
        /// <summary>
        /// Type of registry authentication
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GCPRegistryType Type { get; set; }

        /// <summary>
        /// Service Account JSON for GCP authentication
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("serviceAccountJson", Required = global::Newtonsoft.Json.Required.Always)]
        public string ServiceAccountJson { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GCPRegistry" /> class.
        /// </summary>
        /// <param name="serviceAccountJson">
        /// Service Account JSON for GCP authentication
        /// </param>
        /// <param name="type">
        /// Type of registry authentication
        /// </param>
        public GCPRegistry(
            string serviceAccountJson,
            global::G.GCPRegistryType type)
        {
            this.Type = type;
            this.ServiceAccountJson = serviceAccountJson ?? throw new global::System.ArgumentNullException(nameof(serviceAccountJson));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GCPRegistry" /> class.
        /// </summary>
        public GCPRegistry()
        {
        }
    }
}