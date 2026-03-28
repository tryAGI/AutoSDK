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
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "failure";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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