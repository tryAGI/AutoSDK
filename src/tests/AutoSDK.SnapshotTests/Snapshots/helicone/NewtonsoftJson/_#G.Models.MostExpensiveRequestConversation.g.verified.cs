//HintName: G.Models.MostExpensiveRequestConversation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MostExpensiveRequestConversation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalWords", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalWords { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("turnCount", Required = global::Newtonsoft.Json.Required.Always)]
        public double TurnCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("messages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ConversationMessage> Messages { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MostExpensiveRequestConversation" /> class.
        /// </summary>
        /// <param name="totalWords"></param>
        /// <param name="turnCount"></param>
        /// <param name="messages"></param>
        public MostExpensiveRequestConversation(
            double totalWords,
            double turnCount,
            global::System.Collections.Generic.IList<global::G.ConversationMessage> messages)
        {
            this.TotalWords = totalWords;
            this.TurnCount = turnCount;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MostExpensiveRequestConversation" /> class.
        /// </summary>
        public MostExpensiveRequestConversation()
        {
        }
    }
}