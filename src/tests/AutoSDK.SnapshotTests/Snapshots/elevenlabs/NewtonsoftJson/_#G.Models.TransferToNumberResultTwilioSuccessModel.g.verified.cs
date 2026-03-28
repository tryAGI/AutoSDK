//HintName: G.Models.TransferToNumberResultTwilioSuccessModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferToNumberResultTwilioSuccessModel
    {
        /// <summary>
        /// Default Value: transfer_to_number_twilio_success
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_type")]
        public string? ResultType { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_number", Required = global::Newtonsoft.Json.Required.Always)]
        public string TransferNumber { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_message")]
        public string? ClientMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agent_message", Required = global::Newtonsoft.Json.Required.Always)]
        public string AgentMessage { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conference_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ConferenceName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("post_dial_digits")]
        public string? PostDialDigits { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToNumberResultTwilioSuccessModel" /> class.
        /// </summary>
        /// <param name="transferNumber"></param>
        /// <param name="agentMessage"></param>
        /// <param name="conferenceName"></param>
        /// <param name="resultType">
        /// Default Value: transfer_to_number_twilio_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="reason"></param>
        /// <param name="clientMessage"></param>
        /// <param name="postDialDigits"></param>
        /// <param name="note"></param>
        public TransferToNumberResultTwilioSuccessModel(
            string transferNumber,
            string agentMessage,
            string conferenceName,
            string? resultType,
            string? status,
            string? reason,
            string? clientMessage,
            string? postDialDigits,
            string? note)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.TransferNumber = transferNumber ?? throw new global::System.ArgumentNullException(nameof(transferNumber));
            this.Reason = reason;
            this.ClientMessage = clientMessage;
            this.AgentMessage = agentMessage ?? throw new global::System.ArgumentNullException(nameof(agentMessage));
            this.ConferenceName = conferenceName ?? throw new global::System.ArgumentNullException(nameof(conferenceName));
            this.PostDialDigits = postDialDigits;
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToNumberResultTwilioSuccessModel" /> class.
        /// </summary>
        public TransferToNumberResultTwilioSuccessModel()
        {
        }
    }
}