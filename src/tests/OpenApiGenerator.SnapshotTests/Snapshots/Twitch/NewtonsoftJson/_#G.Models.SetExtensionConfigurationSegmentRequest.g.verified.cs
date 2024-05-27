//HintName: G.Models.SetExtensionConfigurationSegmentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SetExtensionConfigurationSegmentRequest
    {
        /// <summary>
        /// The ID of the extension to update.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extension_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ExtensionId { get; set; } = default!;

        /// <summary>
        /// The configuration segment to update. Possible case-sensitive values are:  
        ///   
        /// * broadcaster
        /// * developer
        /// * global
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("segment", Required = global::Newtonsoft.Json.Required.Always)]
        public SetExtensionConfigurationSegmentRequestSegment Segment { get; set; } = default!;

        /// <summary>
        /// The ID of the broadcaster that installed the extension. Include this field only if the `segment` is set to developer or broadcaster.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id")]
        public string? BroadcasterId { get; set; }

        /// <summary>
        /// The contents of the segment. This string may be a plain-text string or a string-encoded JSON object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The version number that identifies this definition of the segment’s data. If not specified, the latest definition is updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}