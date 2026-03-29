//HintName: G.Models.LettaPing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A ping message used as a keepalive to prevent SSE streams from timing out during long running requests.<br/>
    /// Args:<br/>
    ///     id (str): The ID of the message<br/>
    ///     date (datetime): The date the message was created in ISO format
    /// </summary>
    public sealed partial class LettaPing
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
        /// The type of the message. Ping messages are a keep-alive to prevent SSE streams from timing out during long running requests.<br/>
        /// Default Value: ping
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaPing" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="date"></param>
        /// <param name="name"></param>
        /// <param name="messageType">
        /// The type of the message. Ping messages are a keep-alive to prevent SSE streams from timing out during long running requests.<br/>
        /// Default Value: ping
        /// </param>
        /// <param name="otid"></param>
        /// <param name="senderId"></param>
        /// <param name="stepId"></param>
        /// <param name="isErr"></param>
        /// <param name="seqId"></param>
        /// <param name="runId"></param>
        public LettaPing(
            string id,
            global::System.DateTime date,
            string? name,
            string? messageType,
            string? otid,
            string? senderId,
            string? stepId,
            bool? isErr,
            int? seqId,
            string? runId)
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LettaPing" /> class.
        /// </summary>
        public LettaPing()
        {
        }
    }
}