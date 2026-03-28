//HintName: G.Models.TransferToAgentToolResultSuccessModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferToAgentToolResultSuccessModel
    {
        /// <summary>
        /// Default Value: transfer_to_agent_success
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
        [global::Newtonsoft.Json.JsonProperty("from_agent", Required = global::Newtonsoft.Json.Required.Always)]
        public string FromAgent { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("to_agent", Required = global::Newtonsoft.Json.Required.Always)]
        public string ToAgent { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition", Required = global::Newtonsoft.Json.Required.Always)]
        public string Condition { get; set; } = default!;

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("delay_ms")]
        public int? DelayMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transfer_message")]
        public string? TransferMessage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_transferred_agent_first_message")]
        public bool? EnableTransferredAgentFirstMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("branch_info")]
        public global::G.BranchInfoVariant1? BranchInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToAgentToolResultSuccessModel" /> class.
        /// </summary>
        /// <param name="fromAgent"></param>
        /// <param name="toAgent"></param>
        /// <param name="condition"></param>
        /// <param name="resultType">
        /// Default Value: transfer_to_agent_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="delayMs">
        /// Default Value: 0
        /// </param>
        /// <param name="transferMessage"></param>
        /// <param name="enableTransferredAgentFirstMessage">
        /// Default Value: false
        /// </param>
        /// <param name="branchInfo"></param>
        public TransferToAgentToolResultSuccessModel(
            string fromAgent,
            string toAgent,
            string condition,
            string? resultType,
            string? status,
            int? delayMs,
            string? transferMessage,
            bool? enableTransferredAgentFirstMessage,
            global::G.BranchInfoVariant1? branchInfo)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.FromAgent = fromAgent ?? throw new global::System.ArgumentNullException(nameof(fromAgent));
            this.ToAgent = toAgent ?? throw new global::System.ArgumentNullException(nameof(toAgent));
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.DelayMs = delayMs;
            this.TransferMessage = transferMessage;
            this.EnableTransferredAgentFirstMessage = enableTransferredAgentFirstMessage;
            this.BranchInfo = branchInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToAgentToolResultSuccessModel" /> class.
        /// </summary>
        public TransferToAgentToolResultSuccessModel()
        {
        }
    }
}