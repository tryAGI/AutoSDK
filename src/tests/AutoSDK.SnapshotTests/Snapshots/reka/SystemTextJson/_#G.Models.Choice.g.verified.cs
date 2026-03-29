//HintName: G.Models.Choice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Choice
    {
        /// <summary>
        /// The index of the choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChatMessageOutput Message { get; set; }

        /// <summary>
        /// The reason the model stopped generating tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChoiceFinishReasonJsonConverter))]
        public global::G.ChoiceFinishReason? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Choice" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the choice.
        /// </param>
        /// <param name="message"></param>
        /// <param name="finishReason">
        /// The reason the model stopped generating tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Choice(
            int index,
            global::G.ChatMessageOutput message,
            global::G.ChoiceFinishReason? finishReason)
        {
            this.Index = index;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Choice" /> class.
        /// </summary>
        public Choice()
        {
        }
    }
}