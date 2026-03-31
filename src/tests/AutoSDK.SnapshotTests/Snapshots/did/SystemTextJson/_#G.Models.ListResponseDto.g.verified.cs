//HintName: G.Models.ListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ListResponseDtoConsent> Consents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResponseDto" /> class.
        /// </summary>
        /// <param name="consents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListResponseDto(
            global::System.Collections.Generic.IList<global::G.ListResponseDtoConsent> consents)
        {
            this.Consents = consents ?? throw new global::System.ArgumentNullException(nameof(consents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResponseDto" /> class.
        /// </summary>
        public ListResponseDto()
        {
        }
    }
}