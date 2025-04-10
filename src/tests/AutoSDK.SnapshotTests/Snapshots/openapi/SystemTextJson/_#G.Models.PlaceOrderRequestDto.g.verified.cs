//HintName: G.Models.PlaceOrderRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaceOrderRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.OrderItemDto> Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("walletType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WalletTypeJsonConverter))]
        public global::G.WalletType? WalletType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cryptoOption")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CryptoOptionJsonConverter))]
        public global::G.CryptoOption? CryptoOption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceOrderRequestDto" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="walletType"></param>
        /// <param name="cryptoOption"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaceOrderRequestDto(
            global::System.Collections.Generic.IList<global::G.OrderItemDto> items,
            global::G.WalletType? walletType,
            global::G.CryptoOption? cryptoOption)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.WalletType = walletType;
            this.CryptoOption = cryptoOption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceOrderRequestDto" /> class.
        /// </summary>
        public PlaceOrderRequestDto()
        {
        }
    }
}