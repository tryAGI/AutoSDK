//HintName: G.Models.BreakdownConfigPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BreakdownConfigPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("field")]
        public global::G.BreakdownConfigPublicField? Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_key")]
        public string? MetadataKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sub_metric")]
        public string? SubMetric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BreakdownConfigPublic" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="metadataKey"></param>
        /// <param name="subMetric"></param>
        public BreakdownConfigPublic(
            global::G.BreakdownConfigPublicField? field,
            string? metadataKey,
            string? subMetric)
        {
            this.Field = field;
            this.MetadataKey = metadataKey;
            this.SubMetric = subMetric;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BreakdownConfigPublic" /> class.
        /// </summary>
        public BreakdownConfigPublic()
        {
        }
    }
}