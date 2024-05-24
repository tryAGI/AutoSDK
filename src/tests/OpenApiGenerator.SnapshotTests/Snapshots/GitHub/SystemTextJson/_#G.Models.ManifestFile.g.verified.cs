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
        /// The path of the manifest file relative to the root of the Git repository.
        /// <br/>Example: /src/build/package-lock.json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_location")]
        public string? SourceLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}