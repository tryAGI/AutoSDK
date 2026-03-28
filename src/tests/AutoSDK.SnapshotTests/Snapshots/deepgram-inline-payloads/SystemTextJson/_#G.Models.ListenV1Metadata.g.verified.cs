//HintName: G.Models.ListenV1Metadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata about the transcription session.
    /// </summary>
    public sealed partial class ListenV1Metadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ListenV1MetadataTypeJsonConverter))]
        public global::G.ListenV1MetadataType Type { get; set; }

        /// <summary>
        /// Unique request identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RequestId { get; set; }

        /// <summary>
        /// Audio duration in seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1Metadata" /> class.
        /// </summary>
        /// <param name="requestId">
        /// Unique request identifier.
        /// </param>
        /// <param name="type"></param>
        /// <param name="duration">
        /// Audio duration in seconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListenV1Metadata(
            global::System.Guid requestId,
            global::G.ListenV1MetadataType type,
            double? duration)
        {
            this.Type = type;
            this.RequestId = requestId;
            this.Duration = duration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListenV1Metadata" /> class.
        /// </summary>
        public ListenV1Metadata()
        {
        }
    }
}