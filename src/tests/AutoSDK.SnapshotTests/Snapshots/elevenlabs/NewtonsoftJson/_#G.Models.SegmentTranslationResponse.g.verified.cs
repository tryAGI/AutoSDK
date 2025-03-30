//HintName: G.Models.SegmentTranslationResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SegmentTranslationResponse
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
        /// Initializes a new instance of the <see cref="SegmentTranslationResponse" /> class.
        /// </summary>
        /// <param name="version"></param>
        public SegmentTranslationResponse(
            int version)
        {
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentTranslationResponse" /> class.
        /// </summary>
        public SegmentTranslationResponse()
        {
        }
    }
}