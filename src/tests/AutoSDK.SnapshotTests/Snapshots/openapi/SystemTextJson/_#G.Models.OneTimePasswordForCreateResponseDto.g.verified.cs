//HintName: G.Models.OneTimePasswordForCreateResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OneTimePasswordForCreateResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiryDate")]
        public global::System.DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OneTimePasswordForCreateResponseDto" /> class.
        /// </summary>
        /// <param name="expiryDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OneTimePasswordForCreateResponseDto(
            global::System.DateTime? expiryDate)
        {
            this.ExpiryDate = expiryDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OneTimePasswordForCreateResponseDto" /> class.
        /// </summary>
        public OneTimePasswordForCreateResponseDto()
        {
        }
    }
}