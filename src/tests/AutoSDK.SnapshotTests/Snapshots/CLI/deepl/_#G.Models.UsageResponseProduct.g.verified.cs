//HintName: G.Models.UsageResponseProduct.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageResponseProduct
    {
        /// <summary>
        /// The type of product (e.g., 'write', 'translate').<br/>
        /// Example: write
        /// </summary>
        /// <example>write</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_type")]
        public string? ProductType { get; set; }

        /// <summary>
        /// The billing unit for this product type.<br/>
        /// Example: characters
        /// </summary>
        /// <example>characters</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UsageResponseProductBillingUnitJsonConverter))]
        public global::G.UsageResponseProductBillingUnit? BillingUnit { get; set; }

        /// <summary>
        /// Units used for this product by this API key in the current period.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_unit_count")]
        public int? ApiKeyUnitCount { get; set; }

        /// <summary>
        /// Total units used for this product by the account in the current period.<br/>
        /// Example: 5643
        /// </summary>
        /// <example>5643</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_unit_count")]
        public int? AccountUnitCount { get; set; }

        /// <summary>
        /// Characters used for this product by this API key in the current period.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_character_count")]
        public int? ApiKeyCharacterCount { get; set; }

        /// <summary>
        /// Total characters used for this product in the current period.<br/>
        /// Example: 5643
        /// </summary>
        /// <example>5643</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_count")]
        public int? CharacterCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageResponseProduct" /> class.
        /// </summary>
        /// <param name="productType">
        /// The type of product (e.g., 'write', 'translate').<br/>
        /// Example: write
        /// </param>
        /// <param name="billingUnit">
        /// The billing unit for this product type.<br/>
        /// Example: characters
        /// </param>
        /// <param name="apiKeyUnitCount">
        /// Units used for this product by this API key in the current period.<br/>
        /// Example: 0
        /// </param>
        /// <param name="accountUnitCount">
        /// Total units used for this product by the account in the current period.<br/>
        /// Example: 5643
        /// </param>
        /// <param name="apiKeyCharacterCount">
        /// Characters used for this product by this API key in the current period.<br/>
        /// Example: 0
        /// </param>
        /// <param name="characterCount">
        /// Total characters used for this product in the current period.<br/>
        /// Example: 5643
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageResponseProduct(
            string? productType,
            global::G.UsageResponseProductBillingUnit? billingUnit,
            int? apiKeyUnitCount,
            int? accountUnitCount,
            int? apiKeyCharacterCount,
            int? characterCount)
        {
            this.ProductType = productType;
            this.BillingUnit = billingUnit;
            this.ApiKeyUnitCount = apiKeyUnitCount;
            this.AccountUnitCount = accountUnitCount;
            this.ApiKeyCharacterCount = apiKeyCharacterCount;
            this.CharacterCount = characterCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageResponseProduct" /> class.
        /// </summary>
        public UsageResponseProduct()
        {
        }
    }
}