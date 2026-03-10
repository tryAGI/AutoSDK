//HintName: G.Models.TransferToNumberResultErrorModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferToNumberResultErrorModel
    {
        /// <summary>
        /// Default Value: transfer_to_number_error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        public string? ResultType { get; set; }

        /// <summary>
        /// Default Value: error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public string? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToNumberResultErrorModel" /> class.
        /// </summary>
        /// <param name="resultType">
        /// Default Value: transfer_to_number_error
        /// </param>
        /// <param name="status">
        /// Default Value: error
        /// </param>
        /// <param name="error"></param>
        /// <param name="details"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferToNumberResultErrorModel(
            string error,
            string? resultType,
            string? status,
            string? details)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.ResultType = resultType;
            this.Status = status;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToNumberResultErrorModel" /> class.
        /// </summary>
        public TransferToNumberResultErrorModel()
        {
        }
    }
}