//HintName: G.Models.BatchFailureResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BatchFailureResponseModel
    {
        /// <summary>
        /// Default Value: failure
        /// </summary>
        /// <default>"failure"</default>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string Status { get; set; } = "failure";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_code", Required = global::Newtonsoft.Json.Required.Always)]
        public int ErrorCode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_status", Required = global::Newtonsoft.Json.Required.Always)]
        public string ErrorStatus { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error_message", Required = global::Newtonsoft.Json.Required.Always)]
        public string ErrorMessage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchFailureResponseModel" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorStatus"></param>
        /// <param name="errorMessage"></param>
        /// <param name="status">
        /// Default Value: failure
        /// </param>
        public BatchFailureResponseModel(
            int errorCode,
            string errorStatus,
            string errorMessage,
            string status = "failure")
        {
            this.Status = status;
            this.ErrorCode = errorCode;
            this.ErrorStatus = errorStatus ?? throw new global::System.ArgumentNullException(nameof(errorStatus));
            this.ErrorMessage = errorMessage ?? throw new global::System.ArgumentNullException(nameof(errorMessage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchFailureResponseModel" /> class.
        /// </summary>
        public BatchFailureResponseModel()
        {
        }
    }
}