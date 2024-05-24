//HintName: G.Models.Snapshot.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Create a new snapshot of a repository's dependencies.
    /// </summary>
    public sealed partial class Snapshot
    {
        /// <summary>
        /// The version of the repository snapshot submission.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required SnapshotJob Job { get; set; }

        /// <summary>
        /// The commit SHA associated with this dependency snapshot. Maximum length: 40 characters.
        /// <br/>Example: ddc951f4b1293222421f2c8df679786153acf689
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// The repository branch that triggered this snapshot.
        /// <br/>Example: refs/heads/main
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// A description of the detector used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required SnapshotDetector Detector { get; set; }

        /// <summary>
        /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public Metadata? Metadata { get; set; }

        /// <summary>
        /// A collection of package manifests, which are a collection of related dependencies declared in a file or representing a logical group of dependencies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifests")]
        public object? Manifests { get; set; }

        /// <summary>
        /// The time at which the snapshot was scanned.
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scanned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Scanned { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}