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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ListenV1MetadataType Type { get; set; }

        /// <summary>
        /// Unique request identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("request_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid RequestId { get; set; } = default!;

        /// <summary>
        /// Audio duration in seconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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