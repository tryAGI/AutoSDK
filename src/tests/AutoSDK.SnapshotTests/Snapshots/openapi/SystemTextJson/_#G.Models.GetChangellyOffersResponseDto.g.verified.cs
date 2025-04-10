//HintName: G.Models.GetChangellyOffersResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetChangellyOffersResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("providerCode")]
        public string? ProviderCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        public string? Rate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invertedRate")]
        public string? InvertedRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fee")]
        public string? Fee { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amountFrom")]
        public string? AmountFrom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amountExpectedTo")]
        public string? AmountExpectedTo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChangellyOffersResponseDto" /> class.
        /// </summary>
        /// <param name="providerCode"></param>
        /// <param name="rate"></param>
        /// <param name="invertedRate"></param>
        /// <param name="fee"></param>
        /// <param name="amountFrom"></param>
        /// <param name="amountExpectedTo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetChangellyOffersResponseDto(
            string? providerCode,
            string? rate,
            string? invertedRate,
            string? fee,
            string? amountFrom,
            string? amountExpectedTo)
        {
            this.ProviderCode = providerCode;
            this.Rate = rate;
            this.InvertedRate = invertedRate;
            this.Fee = fee;
            this.AmountFrom = amountFrom;
            this.AmountExpectedTo = amountExpectedTo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetChangellyOffersResponseDto" /> class.
        /// </summary>
        public GetChangellyOffersResponseDto()
        {
        }
    }
}