//HintName: G.Models.ExtensionConfigurationSegment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExtensionConfigurationSegment
    {
        /// <summary>
        /// The type of segment. Possible values are:   <br/>
        ///   <br/>
        /// * broadcaster<br/>
        /// * developer<br/>
        /// * global
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segment", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ExtensionConfigurationSegmentSegment Segment { get; set; } = default!;

        /// <summary>
        /// The ID of the broadcaster that installed the extension. The object includes this field only if the `segment` query parameter is set to developer or broadcaster.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id")]
        public string? BroadcasterId { get; set; }

        /// <summary>
        /// The contents of the segment. This string may be a plain-text string or a string-encoded JSON object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// The version number that identifies this definition of the segment’s data.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionConfigurationSegment" /> class.
        /// </summary>
        /// <param name="segment">
        /// The type of segment. Possible values are:   <br/>
        ///   <br/>
        /// * broadcaster<br/>
        /// * developer<br/>
        /// * global
        /// </param>
        /// <param name="broadcasterId">
        /// The ID of the broadcaster that installed the extension. The object includes this field only if the `segment` query parameter is set to developer or broadcaster.
        /// </param>
        /// <param name="content">
        /// The contents of the segment. This string may be a plain-text string or a string-encoded JSON object.
        /// </param>
        /// <param name="version">
        /// The version number that identifies this definition of the segment’s data.
        /// </param>
        public ExtensionConfigurationSegment(
            global::G.ExtensionConfigurationSegmentSegment segment,
            string content,
            string version,
            string? broadcasterId)
        {
            this.Segment = segment;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.BroadcasterId = broadcasterId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionConfigurationSegment" /> class.
        /// </summary>
        public ExtensionConfigurationSegment()
        {
        }
    }
}