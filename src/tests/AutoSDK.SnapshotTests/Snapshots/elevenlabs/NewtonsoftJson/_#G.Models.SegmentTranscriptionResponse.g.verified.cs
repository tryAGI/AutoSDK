//HintName: G.Models.SegmentTranscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentTranscriptionResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentTranscriptionResponse" /> class.
        /// </summary>
        /// <param name="version"></param>
        public SegmentTranscriptionResponse(
            int version)
        {
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentTranscriptionResponse" /> class.
        /// </summary>
        public SegmentTranscriptionResponse()
        {
        }
    }
}