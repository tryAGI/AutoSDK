//HintName: G.Models.ElseEdgeVariant2TransitionCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ElseEdgeVariant2TransitionCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ElseEdgeVariant2TransitionConditionTypeJsonConverter))]
        public global::G.ElseEdgeVariant2TransitionConditionType Type { get; set; }

        /// <summary>
        /// Must be "Else" for else edge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ElseEdgeVariant2TransitionConditionPromptJsonConverter))]
        public global::G.ElseEdgeVariant2TransitionConditionPrompt Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ElseEdgeVariant2TransitionCondition" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="prompt">
        /// Must be "Else" for else edge
        /// </param>
        public ElseEdgeVariant2TransitionCondition(
            global::G.ElseEdgeVariant2TransitionConditionType type,
            global::G.ElseEdgeVariant2TransitionConditionPrompt prompt)
        {
            this.Type = type;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElseEdgeVariant2TransitionCondition" /> class.
        /// </summary>
        public ElseEdgeVariant2TransitionCondition()
        {
        }
    }
}