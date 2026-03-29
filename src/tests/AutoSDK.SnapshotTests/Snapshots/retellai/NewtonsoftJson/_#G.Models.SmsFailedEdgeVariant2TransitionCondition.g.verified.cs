//HintName: G.Models.SmsFailedEdgeVariant2TransitionCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SmsFailedEdgeVariant2TransitionCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SmsFailedEdgeVariant2TransitionConditionType Type { get; set; }

        /// <summary>
        /// Must be "failed to send" for SMS failed edge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public global::G.SmsFailedEdgeVariant2TransitionConditionPrompt Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsFailedEdgeVariant2TransitionCondition" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="prompt">
        /// Must be "failed to send" for SMS failed edge
        /// </param>
        public SmsFailedEdgeVariant2TransitionCondition(
            global::G.SmsFailedEdgeVariant2TransitionConditionType type,
            global::G.SmsFailedEdgeVariant2TransitionConditionPrompt prompt)
        {
            this.Type = type;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmsFailedEdgeVariant2TransitionCondition" /> class.
        /// </summary>
        public SmsFailedEdgeVariant2TransitionCondition()
        {
        }
    }
}