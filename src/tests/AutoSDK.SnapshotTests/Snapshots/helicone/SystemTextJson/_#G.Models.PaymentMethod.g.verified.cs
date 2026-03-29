//HintName: G.Models.PaymentMethod.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaymentMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("brand")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Brand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last4")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Last4 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exp_month")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpMonth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exp_year")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ExpYear { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="brand"></param>
        /// <param name="last4"></param>
        /// <param name="expMonth"></param>
        /// <param name="expYear"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaymentMethod(
            string id,
            string brand,
            string last4,
            double expMonth,
            double expYear)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Brand = brand ?? throw new global::System.ArgumentNullException(nameof(brand));
            this.Last4 = last4 ?? throw new global::System.ArgumentNullException(nameof(last4));
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethod" /> class.
        /// </summary>
        public PaymentMethod()
        {
        }
    }
}