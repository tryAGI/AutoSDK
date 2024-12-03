//HintName: G.Models.ManifestFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManifestFile
    {
        /// <summary>
        /// The path of the manifest file relative to the root of the Git repository.<br/>
        /// Example: /src/build/package-lock.json
        /// </summary>
        /// <example>/src/build/package-lock.json</example>
        [global::Newtonsoft.Json.JsonProperty("source_location")]
        public string? SourceLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManifestFile" /> class.
        /// </summary>
        /// <param name="sourceLocation">
        /// The path of the manifest file relative to the root of the Git repository.<br/>
        /// Example: /src/build/package-lock.json
        /// </param>
        public ManifestFile(
            string? sourceLocation)
        {
            this.SourceLocation = sourceLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManifestFile" /> class.
        /// </summary>
        public ManifestFile()
        {
        }
    }
}