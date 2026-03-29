//HintName: G.Models.UpdateEvaluationStatusRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateEvaluationStatusRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.UpdateEvaluationStatusRequestStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEvaluationStatusRequest" /> class.
        /// </summary>
        /// <param name="status"></param>
        public UpdateEvaluationStatusRequest(
            global::G.UpdateEvaluationStatusRequestStatus? status)
        {
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEvaluationStatusRequest" /> class.
        /// </summary>
        public UpdateEvaluationStatusRequest()
        {
        }
    }
}