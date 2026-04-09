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
        [global::Newtonsoft.Json.JsonProperty("_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LastMileConfigFormVariant2Variant1TypeJsonConverter))]
        public global::G.LastMileConfigFormVariant2Variant1Type Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LastMileConfigFormVariant2Variant1" /> class.
        /// </summary>
        /// <param name="type"></param>
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