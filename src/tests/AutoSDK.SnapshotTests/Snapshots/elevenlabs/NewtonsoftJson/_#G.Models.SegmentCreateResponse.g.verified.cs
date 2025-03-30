//HintName: G.Models.SegmentCreateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentCreateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_segment", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewSegment { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentCreateResponse" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="newSegment"></param>
        public SegmentCreateResponse(
            int version,
            string newSegment)
        {
            this.Version = version;
            this.NewSegment = newSegment ?? throw new global::System.ArgumentNullException(nameof(newSegment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentCreateResponse" /> class.
        /// </summary>
        public SegmentCreateResponse()
        {
        }
    }
}