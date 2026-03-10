//HintName: G.Models.TransferToNumberResultSipSuccessModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferToNumberResultSipSuccessModel
    {
        /// <summary>
        /// Default Value: transfer_to_number_sip_success
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
        [global::Newtonsoft.Json.JsonProperty("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToNumberResultSipSuccessModel" /> class.
        /// </summary>
        /// <param name="resultType">
        /// Default Value: transfer_to_number_sip_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="transferNumber"></param>
        /// <param name="reason"></param>
        /// <param name="note"></param>
        public TransferToNumberResultSipSuccessModel(
            string transferNumber,
            string? resultType,
            string? status,
            string? reason,
            string? note)
        {
            this.TransferNumber = transferNumber ?? throw new global::System.ArgumentNullException(nameof(transferNumber));
            this.ResultType = resultType;
            this.Status = status;
            this.Reason = reason;
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToNumberResultSipSuccessModel" /> class.
        /// </summary>
        public TransferToNumberResultSipSuccessModel()
        {
        }
    }
}