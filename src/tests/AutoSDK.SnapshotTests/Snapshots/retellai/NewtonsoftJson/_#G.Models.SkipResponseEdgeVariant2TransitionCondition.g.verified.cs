//HintName: G.Models.SkipResponseEdgeVariant2TransitionCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SkipResponseEdgeVariant2TransitionCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SkipResponseEdgeVariant2TransitionConditionTypeJsonConverter))]
        public global::G.SkipResponseEdgeVariant2TransitionConditionType Type { get; set; }

        /// <summary>
        /// Must be "Skip response" for skip response edge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.SkipResponseEdgeVariant2TransitionConditionPromptJsonConverter))]
        public global::G.SkipResponseEdgeVariant2TransitionConditionPrompt Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkipResponseEdgeVariant2TransitionCondition" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="prompt">
        /// Must be "Skip response" for skip response edge
        /// </param>
        public SkipResponseEdgeVariant2TransitionCondition(
            global::G.SkipResponseEdgeVariant2TransitionConditionType type,
            global::G.SkipResponseEdgeVariant2TransitionConditionPrompt prompt)
        {
            this.Type = type;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkipResponseEdgeVariant2TransitionCondition" /> class.
        /// </summary>
        public SkipResponseEdgeVariant2TransitionCondition()
        {
        }
    }
}