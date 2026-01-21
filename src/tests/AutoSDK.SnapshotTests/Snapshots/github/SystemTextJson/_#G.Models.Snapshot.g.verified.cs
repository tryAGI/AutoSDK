//HintName: G.Models.Snapshot.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        public required global::G.SnapshotJob Job { get; set; }

        /// <summary>
        /// The commit SHA associated with this dependency snapshot. Maximum length: 40 characters.<br/>
        /// Example: ddc951f4b1293222421f2c8df679786153acf689
        /// </summary>
        /// <example>ddc951f4b1293222421f2c8df679786153acf689</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sha { get; set; }

        /// <summary>
        /// The repository branch that triggered this snapshot.<br/>
        /// Example: refs/heads/main
        /// </summary>
        /// <example>refs/heads/main</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// A description of the detector used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detector")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SnapshotDetector Detector { get; set; }

        /// <summary>
        /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, global::G.AnyOf<string, double?, bool?>?>? Metadata { get; set; }

        /// <summary>
        /// A collection of package manifests, which are a collection of related dependencies declared in a file or representing a logical group of dependencies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifests")]
        public global::System.Collections.Generic.Dictionary<string, global::G.Manifest>? Manifests { get; set; }

        /// <summary>
        /// The time at which the snapshot was scanned.<br/>
        /// Example: 2020-06-13T14:52:50-05:00
        /// </summary>
        /// <example>2020-06-13T14:52:50-05:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scanned")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Scanned { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Snapshot" /> class.
        /// </summary>
        /// <param name="version">
        /// The version of the repository snapshot submission.
        /// </param>
        /// <param name="job"></param>
        /// <param name="sha">
        /// The commit SHA associated with this dependency snapshot. Maximum length: 40 characters.<br/>
        /// Example: ddc951f4b1293222421f2c8df679786153acf689
        /// </param>
        /// <param name="ref">
        /// The repository branch that triggered this snapshot.<br/>
        /// Example: refs/heads/main
        /// </param>
        /// <param name="detector">
        /// A description of the detector used.
        /// </param>
        /// <param name="metadata">
        /// User-defined metadata to store domain-specific information limited to 8 keys with scalar values.
        /// </param>
        /// <param name="manifests">
        /// A collection of package manifests, which are a collection of related dependencies declared in a file or representing a logical group of dependencies.
        /// </param>
        /// <param name="scanned">
        /// The time at which the snapshot was scanned.<br/>
        /// Example: 2020-06-13T14:52:50-05:00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Snapshot(
            int version,
            global::G.SnapshotJob job,
            string sha,
            string @ref,
            global::G.SnapshotDetector detector,
            global::System.DateTime scanned,
            global::System.Collections.Generic.Dictionary<string, global::G.AnyOf<string, double?, bool?>?>? metadata,
            global::System.Collections.Generic.Dictionary<string, global::G.Manifest>? manifests)
        {
            this.Version = version;
            this.Job = job ?? throw new global::System.ArgumentNullException(nameof(job));
            this.Sha = sha ?? throw new global::System.ArgumentNullException(nameof(sha));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
            this.Detector = detector ?? throw new global::System.ArgumentNullException(nameof(detector));
            this.Scanned = scanned;
            this.Metadata = metadata;
            this.Manifests = manifests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Snapshot" /> class.
        /// </summary>
        public Snapshot()
        {
        }
    }
}