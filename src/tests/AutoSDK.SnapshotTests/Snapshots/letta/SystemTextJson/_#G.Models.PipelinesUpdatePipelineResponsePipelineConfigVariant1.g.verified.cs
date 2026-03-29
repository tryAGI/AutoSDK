//HintName: G.Models.PipelinesUpdatePipelineResponsePipelineConfigVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PipelinesUpdatePipelineResponsePipelineConfigVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PipelinesUpdatePipelineResponsePipelineConfigVariant1TypeJsonConverter))]
        public global::G.PipelinesUpdatePipelineResponsePipelineConfigVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PipelinesUpdatePipelineResponsePipelineConfigVariant1Data Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineResponsePipelineConfigVariant1" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PipelinesUpdatePipelineResponsePipelineConfigVariant1(
            global::G.PipelinesUpdatePipelineResponsePipelineConfigVariant1Data data,
            global::G.PipelinesUpdatePipelineResponsePipelineConfigVariant1Type type)
        {
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PipelinesUpdatePipelineResponsePipelineConfigVariant1" /> class.
        /// </summary>
        public PipelinesUpdatePipelineResponsePipelineConfigVariant1()
        {
        }
    }
}