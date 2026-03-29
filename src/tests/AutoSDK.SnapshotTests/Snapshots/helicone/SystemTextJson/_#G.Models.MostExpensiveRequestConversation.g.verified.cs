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
        [global::System.Text.Json.Serialization.JsonPropertyName("totalWords")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalWords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turnCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TurnCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ConversationMessage> Messages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MostExpensiveRequestConversation" /> class.
        /// </summary>
        /// <param name="totalWords"></param>
        /// <param name="turnCount"></param>
        /// <param name="messages"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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