//HintName: G.Models.OrderForActivateRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrderForActivateRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("walletFundingRequest")]
        public bool? WalletFundingRequest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderForActivateRequestDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="walletFundingRequest"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrderForActivateRequestDto(
            long? id,
            bool? walletFundingRequest)
        {
            this.Id = id;
            this.WalletFundingRequest = walletFundingRequest;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderForActivateRequestDto" /> class.
        /// </summary>
        public OrderForActivateRequestDto()
        {
        }
    }
}