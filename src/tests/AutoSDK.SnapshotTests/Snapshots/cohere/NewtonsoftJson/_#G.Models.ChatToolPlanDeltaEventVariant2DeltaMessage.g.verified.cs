//HintName: G.Models.ChatToolPlanDeltaEventVariant2DeltaMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatToolPlanDeltaEventVariant2DeltaMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_plan")]
        public string? ToolPlan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolPlanDeltaEventVariant2DeltaMessage" /> class.
        /// </summary>
        /// <param name="toolPlan"></param>
        public ChatToolPlanDeltaEventVariant2DeltaMessage(
            string? toolPlan)
        {
            this.ToolPlan = toolPlan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatToolPlanDeltaEventVariant2DeltaMessage" /> class.
        /// </summary>
        public ChatToolPlanDeltaEventVariant2DeltaMessage()
        {
        }
    }
}