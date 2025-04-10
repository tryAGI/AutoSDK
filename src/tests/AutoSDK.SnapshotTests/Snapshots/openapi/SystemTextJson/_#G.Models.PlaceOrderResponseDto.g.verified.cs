//HintName: G.Models.PlaceOrderResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PlaceOrderResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isPaid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPaid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("walletFundingRequest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WalletFundingRequestForCreateResponseDto? WalletFundingRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceOrderResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isPaid"></param>
        /// <param name="walletFundingRequest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlaceOrderResponseDto(
            long id,
            bool isPaid,
            global::G.WalletFundingRequestForCreateResponseDto? walletFundingRequest)
        {
            this.Id = id;
            this.IsPaid = isPaid;
            this.WalletFundingRequest = walletFundingRequest ?? throw new global::System.ArgumentNullException(nameof(walletFundingRequest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceOrderResponseDto" /> class.
        /// </summary>
        public PlaceOrderResponseDto()
        {
        }
    }
}