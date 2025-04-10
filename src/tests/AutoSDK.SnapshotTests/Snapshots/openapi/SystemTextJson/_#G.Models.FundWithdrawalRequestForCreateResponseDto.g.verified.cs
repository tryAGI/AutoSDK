//HintName: G.Models.FundWithdrawalRequestForCreateResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FundWithdrawalRequestForCreateResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FundWithdrawalRequestForCreateResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FundWithdrawalRequestForCreateResponseDto(
            long? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundWithdrawalRequestForCreateResponseDto" /> class.
        /// </summary>
        public FundWithdrawalRequestForCreateResponseDto()
        {
        }
    }
}