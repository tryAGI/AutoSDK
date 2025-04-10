//HintName: G.Models.SecurityWordsForOtpResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecurityWordsForOtpResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validated")]
        public bool? Validated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityWordsForOtpResponseDto" /> class.
        /// </summary>
        /// <param name="validated"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecurityWordsForOtpResponseDto(
            bool? validated)
        {
            this.Validated = validated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityWordsForOtpResponseDto" /> class.
        /// </summary>
        public SecurityWordsForOtpResponseDto()
        {
        }
    }
}