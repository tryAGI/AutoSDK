//HintName: G.Models.GetWalletResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetWalletResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WalletTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WalletType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Balance { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWalletResponseDto" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="balance"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetWalletResponseDto(
            global::G.WalletType type,
            double balance)
        {
            this.Type = type;
            this.Balance = balance;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetWalletResponseDto" /> class.
        /// </summary>
        public GetWalletResponseDto()
        {
        }
    }
}