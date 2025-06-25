//HintName: G.Models.BetaBillingError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaBillingError
    {
        /// <summary>
        /// Default Value: billing_error
        /// </summary>
        /// <default>global::G.BetaBillingErrorType.BillingError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BetaBillingErrorTypeJsonConverter))]
        public global::G.BetaBillingErrorType Type { get; set; } = global::G.BetaBillingErrorType.BillingError;

        /// <summary>
        /// Default Value: Billing error
        /// </summary>
        /// <default>"Billing error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Billing error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBillingError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: billing_error
        /// </param>
        /// <param name="message">
        /// Default Value: Billing error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBillingError(
            string message,
            global::G.BetaBillingErrorType type = global::G.BetaBillingErrorType.BillingError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBillingError" /> class.
        /// </summary>
        public BetaBillingError()
        {
        }
    }
}