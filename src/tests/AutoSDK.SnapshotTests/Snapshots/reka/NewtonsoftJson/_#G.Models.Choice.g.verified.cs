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
        [global::Newtonsoft.Json.JsonProperty("index", Required = global::Newtonsoft.Json.Required.Always)]
        public int Index { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChatMessageOutput Message { get; set; } = default!;

        /// <summary>
        /// The reason the model stopped generating tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finish_reason")]
        public global::G.ChoiceFinishReason? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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