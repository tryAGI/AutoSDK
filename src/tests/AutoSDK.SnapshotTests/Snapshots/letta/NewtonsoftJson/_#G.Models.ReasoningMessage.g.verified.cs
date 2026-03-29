//HintName: G.Models.ReasoningMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of an agent's internal reasoning.<br/>
    /// Args:<br/>
    ///     id (str): The ID of the message<br/>
    ///     date (datetime): The date the message was created in ISO format<br/>
    ///     name (Optional[str]): The name of the sender of the message<br/>
    ///     source (Literal["reasoner_model", "non_reasoner_model"]): Whether the reasoning<br/>
    ///         content was generated natively by a reasoner model or derived via prompting<br/>
    ///     reasoning (str): The internal reasoning of the agent<br/>
    ///     signature (Optional[str]): The model-generated signature of the reasoning step
    /// </summary>
    public sealed partial class ReasoningMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("date", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Date { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The type of the message.<br/>
        /// Default Value: reasoning_message
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message_type")]
        public string? MessageType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("otid")]
        public string? Otid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sender_id")]
        public string? SenderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("step_id")]
        public string? StepId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_err")]
        public bool? IsErr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seq_id")]
        public int? SeqId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// Default Value: non_reasoner_model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public global::G.ReasoningMessageSource? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reasoning { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningMessage" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="reasoning"></param>
        /// <param name="name"></param>
        /// <param name="messageType">
        /// The type of the message.<br/>
        /// Default Value: reasoning_message
        /// </param>
        /// <param name="otid"></param>
        /// <param name="senderId"></param>
        /// <param name="stepId"></param>
        /// <param name="isErr"></param>
        /// <param name="seqId"></param>
        /// <param name="runId"></param>
        /// <param name="source">
        /// Default Value: non_reasoner_model
        /// </param>
        /// <param name="signature"></param>
        public ReasoningMessage(
            string id,
            global::System.DateTime date,
            string reasoning,
            string? name,
            string? messageType,
            string? otid,
            string? senderId,
            string? stepId,
            bool? isErr,
            int? seqId,
            string? runId,
            global::G.ReasoningMessageSource? source,
            string? signature)
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
            this.Source = source;
            this.Reasoning = reasoning ?? throw new global::System.ArgumentNullException(nameof(reasoning));
            this.Signature = signature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningMessage" /> class.
        /// </summary>
        public ReasoningMessage()
        {
        }
    }
}