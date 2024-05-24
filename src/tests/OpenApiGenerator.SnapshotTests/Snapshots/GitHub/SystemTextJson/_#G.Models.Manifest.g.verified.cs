//HintName: G.Models.Manifest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Manifest
    {
        /// <summary>
        /// The name of the manifest.
        /// <br/>Example: package-lock.json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public ManifestFile? File { get; set; }

        /// <summary>
        /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public Metadata? Metadata { get; set; }

        /// <summary>
        /// A collection of resolved package dependencies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved")]
        public object? Resolved { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}