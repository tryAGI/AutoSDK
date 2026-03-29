//HintName: G.Models.PaymentRequiredResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Payment Required - Insufficient credits or quota to complete request
    /// </summary>
    public sealed partial class PaymentRequiredResponse
    {
        /// <summary>
        /// Error data for PaymentRequiredResponse
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PaymentRequiredResponseErrorData Error { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequiredResponse" /> class.
        /// </summary>
        /// <param name="error">
        /// Error data for PaymentRequiredResponse
        /// </param>
        /// <param name="userId"></param>
        public PaymentRequiredResponse(
            global::G.PaymentRequiredResponseErrorData error,
            string? userId)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequiredResponse" /> class.
        /// </summary>
        public PaymentRequiredResponse()
        {
        }
    }
}