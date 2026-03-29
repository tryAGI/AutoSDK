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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GCPRegistryTypeJsonConverter))]
        public global::G.GCPRegistryType Type { get; set; }

        /// <summary>
        /// Service Account JSON for GCP authentication
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serviceAccountJson")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountJson { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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