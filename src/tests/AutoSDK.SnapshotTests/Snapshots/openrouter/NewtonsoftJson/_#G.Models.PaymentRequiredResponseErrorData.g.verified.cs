//HintName: G.Models.PaymentRequiredResponseErrorData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error data for PaymentRequiredResponse
    /// </summary>
    public sealed partial class PaymentRequiredResponseErrorData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public int Code { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequiredResponseErrorData" /> class.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        /// <param name="metadata"></param>
        public PaymentRequiredResponseErrorData(
            int code,
            string message,
            object? metadata)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequiredResponseErrorData" /> class.
        /// </summary>
        public PaymentRequiredResponseErrorData()
        {
        }
    }
}