//HintName: G.Models.CreateChagellyDepositResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateChagellyDepositResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirectUrl")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChagellyDepositResponseDto" /> class.
        /// </summary>
        /// <param name="redirectUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChagellyDepositResponseDto(
            string? redirectUrl)
        {
            this.RedirectUrl = redirectUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChagellyDepositResponseDto" /> class.
        /// </summary>
        public CreateChagellyDepositResponseDto()
        {
        }
    }
}