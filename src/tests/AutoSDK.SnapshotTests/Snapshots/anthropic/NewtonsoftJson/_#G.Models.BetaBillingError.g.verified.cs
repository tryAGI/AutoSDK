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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaBillingErrorType Type { get; set; } = global::G.BetaBillingErrorType.BillingError;

        /// <summary>
        /// Default Value: Billing error
        /// </summary>
        /// <default>"Billing error"</default>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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