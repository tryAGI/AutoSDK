//HintName: G.Models.LastMileConfigFormVariant2Variant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LastMileConfigFormVariant2Variant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groundTruth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DataEntryJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DataEntry GroundTruth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LastMileConfigFormVariant2Variant2TypeJsonConverter))]
        public global::G.LastMileConfigFormVariant2Variant2Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LastMileConfigFormVariant2Variant2" /> class.
        /// </summary>
        /// <param name="groundTruth"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LastMileConfigFormVariant2Variant2(
            global::G.DataEntry groundTruth,
            global::G.LastMileConfigFormVariant2Variant2Type type)
        {
            this.GroundTruth = groundTruth;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LastMileConfigFormVariant2Variant2" /> class.
        /// </summary>
        public LastMileConfigFormVariant2Variant2()
        {
        }
    }
}