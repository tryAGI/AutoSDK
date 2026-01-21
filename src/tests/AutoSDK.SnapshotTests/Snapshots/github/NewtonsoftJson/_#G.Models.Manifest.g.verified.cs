//HintName: G.Models.Manifest.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file")]
        public global::G.ManifestFile? File { get; set; }

        /// <summary>
        /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, global::G.AnyOf<string, double?, bool?>?>? Metadata { get; set; }

        /// <summary>
        /// A collection of resolved package dependencies.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolved")]
        public global::System.Collections.Generic.Dictionary<string, global::G.Dependency>? Resolved { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        public Manifest(
            string name,
            global::G.ManifestFile? file,
            global::System.Collections.Generic.Dictionary<string, global::G.AnyOf<string, double?, bool?>?>? metadata,
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