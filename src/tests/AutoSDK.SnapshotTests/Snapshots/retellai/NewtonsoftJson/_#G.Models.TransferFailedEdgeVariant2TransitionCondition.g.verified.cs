//HintName: G.Models.TransferFailedEdgeVariant2TransitionCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferFailedEdgeVariant2TransitionCondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.TransferFailedEdgeVariant2TransitionConditionType Type { get; set; }

        /// <summary>
        /// Must be "Transfer failed" for transfer failed edge
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt")]
        public global::G.TransferFailedEdgeVariant2TransitionConditionPrompt Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferFailedEdgeVariant2TransitionCondition" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="prompt">
        /// Must be "Transfer failed" for transfer failed edge
        /// </param>
        public TransferFailedEdgeVariant2TransitionCondition(
            global::G.TransferFailedEdgeVariant2TransitionConditionType type,
            global::G.TransferFailedEdgeVariant2TransitionConditionPrompt prompt)
        {
            this.Type = type;
            this.Prompt = prompt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferFailedEdgeVariant2TransitionCondition" /> class.
        /// </summary>
        public TransferFailedEdgeVariant2TransitionCondition()
        {
        }
    }
}