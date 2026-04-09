//HintName: G.Models.ModelChoiceCascading.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelChoiceCascading
    {
        /// <summary>
        /// Type of model choice
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ModelChoiceCascadingTypeJsonConverter))]
        public global::G.ModelChoiceCascadingType Type { get; set; }

        /// <summary>
        /// Available LLM models for agents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LLMModelJsonConverter))]
        public global::G.LLMModel Model { get; set; } = default!;

        /// <summary>
        /// Whether to use high priority pool with more dedicated resource, default false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("high_priority")]
        public bool? HighPriority { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelChoiceCascading" /> class.
        /// </summary>
        /// <param name="model">
        /// Available LLM models for agents.
        /// </param>
        /// <param name="type">
        /// Type of model choice
        /// </param>
        /// <param name="highPriority">
        /// Whether to use high priority pool with more dedicated resource, default false
        /// </param>
        public ModelChoiceCascading(
            global::G.LLMModel model,
            global::G.ModelChoiceCascadingType type,
            bool? highPriority)
        {
            this.Type = type;
            this.Model = model;
            this.HighPriority = highPriority;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelChoiceCascading" /> class.
        /// </summary>
        public ModelChoiceCascading()
        {
        }
    }
}