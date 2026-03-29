//HintName: G.Models.PaymentErrorError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaymentErrorError
    {
        /// <summary>
        /// The details of the error<br/>
        /// Example: API credits exhausted. Visit https://app.photoroom.com/api-dashboard to purchase more API credits
        /// </summary>
        /// <example>API credits exhausted. Visit https://app.photoroom.com/api-dashboard to purchase more API credits</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentErrorError" /> class.
        /// </summary>
        /// <param name="detail">
        /// The details of the error<br/>
        /// Example: API credits exhausted. Visit https://app.photoroom.com/api-dashboard to purchase more API credits
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaymentErrorError(
            string detail)
        {
            this.Detail = detail ?? throw new global::System.ArgumentNullException(nameof(detail));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentErrorError" /> class.
        /// </summary>
        public PaymentErrorError()
        {
        }
    }
}