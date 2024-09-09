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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The version of the detector used.<br/>
        /// Example: 1.0.0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// The url of the detector used.<br/>
        /// Example: http://example.com/docker-buildtimer-detector
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}