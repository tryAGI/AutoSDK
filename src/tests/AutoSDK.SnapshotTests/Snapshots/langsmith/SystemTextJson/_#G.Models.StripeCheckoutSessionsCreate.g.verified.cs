//HintName: G.Models.StripeCheckoutSessionsCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StripeCheckoutSessionsCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AmountCents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SuccessPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCheckoutSessionsCreate" /> class.
        /// </summary>
        /// <param name="amountCents"></param>
        /// <param name="successPath"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StripeCheckoutSessionsCreate(
            int amountCents,
            string successPath)
        {
            this.AmountCents = amountCents;
            this.SuccessPath = successPath ?? throw new global::System.ArgumentNullException(nameof(successPath));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripeCheckoutSessionsCreate" /> class.
        /// </summary>
        public StripeCheckoutSessionsCreate()
        {
        }
    }
}