//HintName: G.Models.HiddenReasoningMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of an agent's internal reasoning where reasoning content<br/>
    /// has been hidden from the response.<br/>
    /// Args:<br/>
    ///     id (str): The ID of the message<br/>
    ///     date (datetime): The date the message was created in ISO format<br/>
    ///     name (Optional[str]): The name of the sender of the message<br/>
    ///     state (Literal["redacted", "omitted"]): Whether the reasoning<br/>
    ///         content was redacted by the provider or simply omitted by the API<br/>
    ///     hidden_reasoning (Optional[str]): The internal reasoning of the agent
    /// </summary>
    public sealed partial class HiddenReasoningMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The type of the message.<br/>
        /// Default Value: hidden_reasoning_message
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("otid")]
        public string? Otid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sender_id")]
        public string? SenderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_id")]
        public string? StepId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_err")]
        public bool? IsErr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seq_id")]
        public int? SeqId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.HiddenReasoningMessageStateJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.HiddenReasoningMessageState State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hidden_reasoning")]
        public string? HiddenReasoning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HiddenReasoningMessage" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="state"></param>
        /// <param name="name"></param>
        /// <param name="messageType">
        /// The type of the message.<br/>
        /// Default Value: hidden_reasoning_message
        /// </param>
        /// <param name="otid"></param>
        /// <param name="senderId"></param>
        /// <param name="stepId"></param>
        /// <param name="isErr"></param>
        /// <param name="seqId"></param>
        /// <param name="runId"></param>
        /// <param name="hiddenReasoning"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HiddenReasoningMessage(
            string id,
            global::System.DateTime date,
            global::G.HiddenReasoningMessageState state,
            string? name,
            string? messageType,
            string? otid,
            string? senderId,
            string? stepId,
            bool? isErr,
            int? seqId,
            string? runId,
            string? hiddenReasoning)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Date = date;
            this.Name = name;
            this.MessageType = messageType;
            this.Otid = otid;
            this.SenderId = senderId;
            this.StepId = stepId;
            this.IsErr = isErr;
            this.SeqId = seqId;
            this.RunId = runId;
            this.State = state;
            this.HiddenReasoning = hiddenReasoning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HiddenReasoningMessage" /> class.
        /// </summary>
        public HiddenReasoningMessage()
        {
        }
    }
}