//HintName: G.Models.TransferToAgentToolResultErrorModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferToAgentToolResultErrorModel
    {
        /// <summary>
        /// Default Value: transfer_to_agent_error
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_type")]
        public string? ResultType { get; set; }

        /// <summary>
        /// Default Value: error
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
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public string Error { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToAgentToolResultErrorModel" /> class.
        /// </summary>
        /// <param name="fromAgent"></param>
        /// <param name="error"></param>
        /// <param name="resultType">
        /// Default Value: transfer_to_agent_error
        /// </param>
        /// <param name="status">
        /// Default Value: error
        /// </param>
        public TransferToAgentToolResultErrorModel(
            string fromAgent,
            string error,
            string? resultType,
            string? status)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.FromAgent = fromAgent ?? throw new global::System.ArgumentNullException(nameof(fromAgent));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToAgentToolResultErrorModel" /> class.
        /// </summary>
        public TransferToAgentToolResultErrorModel()
        {
        }
    }
}