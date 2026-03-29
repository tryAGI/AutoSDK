//HintName: G.Models.LastMileConfigFormVariant2Variant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LastMileConfigFormVariant2Variant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LastMileConfigFormVariant2Variant1TypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LastMileConfigFormVariant2Variant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LastMileConfigFormVariant2Variant1" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LastMileConfigFormVariant2Variant1(
            global::G.LastMileConfigFormVariant2Variant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LastMileConfigFormVariant2Variant1" /> class.
        /// </summary>
        public LastMileConfigFormVariant2Variant1()
        {
        }
    }
}