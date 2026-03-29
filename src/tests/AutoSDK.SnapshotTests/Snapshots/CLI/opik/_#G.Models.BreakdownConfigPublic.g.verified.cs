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
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BreakdownConfigPublicFieldJsonConverter))]
        public global::G.BreakdownConfigPublicField? Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_key")]
        public string? MetadataKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_metric")]
        public string? SubMetric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BreakdownConfigPublic" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="metadataKey"></param>
        /// <param name="subMetric"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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