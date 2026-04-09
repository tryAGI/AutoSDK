//HintName: G.Models.AIEdgeCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AIEdgeCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AIEdgeConditionTypeJsonConverter))]
        public global::G.AIEdgeConditionType Type { get; set; }

        /// <summary>
        /// This is the prompt for the AI edge condition. It should evaluate to a boolean.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string Prompt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AIEdgeCondition" /> class.
        /// </summary>
        /// <param name="prompt">
        /// This is the prompt for the AI edge condition. It should evaluate to a boolean.
        /// </param>
        /// <param name="type"></param>
        public AIEdgeCondition(
            string prompt,
            global::G.AIEdgeConditionType type)
        {
            this.Type = type;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AIEdgeCondition" /> class.
        /// </summary>
        public AIEdgeCondition()
        {
        }
    }
}