//HintName: G.Models.ContextEngineeringPlanLastNMessages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContextEngineeringPlanLastNMessages
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ContextEngineeringPlanLastNMessagesType Type { get; set; }

        /// <summary>
        /// This is the maximum number of messages to include in the context engineering plan.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maxMessages", Required = global::Newtonsoft.Json.Required.Always)]
        public double MaxMessages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextEngineeringPlanLastNMessages" /> class.
        /// </summary>
        /// <param name="maxMessages">
        /// This is the maximum number of messages to include in the context engineering plan.
        /// </param>
        /// <param name="type"></param>
        public ContextEngineeringPlanLastNMessages(
            double maxMessages,
            global::G.ContextEngineeringPlanLastNMessagesType type)
        {
            this.Type = type;
            this.MaxMessages = maxMessages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextEngineeringPlanLastNMessages" /> class.
        /// </summary>
        public ContextEngineeringPlanLastNMessages()
        {
        }
    }
}