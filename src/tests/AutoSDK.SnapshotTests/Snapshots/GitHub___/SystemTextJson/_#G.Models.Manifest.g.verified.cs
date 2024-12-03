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
        /// The name of the manifest.<br/>
        /// Example: package-lock.json
        /// </summary>
        /// <example>package-lock.json</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public global::G.ManifestFile? File { get; set; }

        /// <summary>
        /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// A collection of resolved package dependencies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved")]
        public global::System.Collections.Generic.Dictionary<string, global::G.Dependency>? Resolved { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Manifest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the manifest.<br/>
        /// Example: package-lock.json
        /// </param>
        /// <param name="file"></param>
        /// <param name="metadata">
        /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
        /// </param>
        /// <param name="resolved">
        /// A collection of resolved package dependencies.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Manifest(
            string name,
            global::G.ManifestFile? file,
            object? metadata,
            global::System.Collections.Generic.Dictionary<string, global::G.Dependency>? resolved)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.File = file;
            this.Metadata = metadata;
            this.Resolved = resolved;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Manifest" /> class.
        /// </summary>
        public Manifest()
        {
        }
    }
}