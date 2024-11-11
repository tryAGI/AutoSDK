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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The version of the detector used.<br/>
        /// Example: 1.0.0
        /// </summary>
        /// <example>1.0.0</example>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// The url of the detector used.<br/>
        /// Example: http://example.com/docker-buildtimer-detector
        /// </summary>
        /// <example>http://example.com/docker-buildtimer-detector</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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