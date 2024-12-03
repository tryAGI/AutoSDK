//HintName: G.Models.SnapshotDetector.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A description of the detector used.
    /// </summary>
    public sealed partial class SnapshotDetector
    {
        /// <summary>
        /// The name of the detector used.<br/>
        /// Example: docker buildtime detector
        /// </summary>
        /// <example>docker buildtime detector</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The version of the detector used.<br/>
        /// Example: 1.0.0
        /// </summary>
        /// <example>1.0.0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// The url of the detector used.<br/>
        /// Example: http://example.com/docker-buildtimer-detector
        /// </summary>
        /// <example>http://example.com/docker-buildtimer-detector</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotDetector" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the detector used.<br/>
        /// Example: docker buildtime detector
        /// </param>
        /// <param name="version">
        /// The version of the detector used.<br/>
        /// Example: 1.0.0
        /// </param>
        /// <param name="url">
        /// The url of the detector used.<br/>
        /// Example: http://example.com/docker-buildtimer-detector
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SnapshotDetector(
            string name,
            string version,
            string url)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SnapshotDetector" /> class.
        /// </summary>
        public SnapshotDetector()
        {
        }
    }
}