﻿//HintName: G.Models.ExtensionConfigurationSegment.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("segment")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExtensionConfigurationSegmentSegmentJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExtensionConfigurationSegmentSegment Segment { get; set; }

        /// <summary>
        /// The ID of the broadcaster that installed the extension. The object includes this field only if the `segment` query parameter is set to developer or broadcaster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("broadcaster_id")]
        public string? BroadcasterId { get; set; }

        /// <summary>
        /// The contents of the segment. This string may be a plain-text string or a string-encoded JSON object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// The version number that identifies this definition of the segment’s data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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