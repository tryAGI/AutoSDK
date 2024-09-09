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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The version of the detector used.<br/>
        /// Example: 1.0.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// The url of the detector used.<br/>
        /// Example: http://example.com/docker-buildtimer-detector
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}