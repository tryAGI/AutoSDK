//HintName: G.Models.PipelinesCreatePipelineRequestProducerConfigVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesCreatePipelineRequestProducerConfigVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PipelinesCreatePipelineRequestProducerConfigVariant1TypeJsonConverter))]
        public global::G.PipelinesCreatePipelineRequestProducerConfigVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PipelinesCreatePipelineRequestProducerConfigVariant1Data Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesCreatePipelineRequestProducerConfigVariant1" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinesCreatePipelineRequestProducerConfigVariant1(
            global::G.PipelinesCreatePipelineRequestProducerConfigVariant1Data data,
            global::G.PipelinesCreatePipelineRequestProducerConfigVariant1Type type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesCreatePipelineRequestProducerConfigVariant1" /> class.
        /// </summary>
        public PipelinesCreatePipelineRequestProducerConfigVariant1()
        {
        }
    }
}