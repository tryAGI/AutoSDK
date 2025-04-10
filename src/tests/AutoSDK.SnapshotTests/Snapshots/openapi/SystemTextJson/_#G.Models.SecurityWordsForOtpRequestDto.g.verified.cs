//HintName: G.Models.SecurityWordsForOtpRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecurityWordsForOtpRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public string? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityWordsForOtpRequestDto" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="words"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecurityWordsForOtpRequestDto(
            long? userId,
            string? words)
        {
            this.UserId = userId;
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityWordsForOtpRequestDto" /> class.
        /// </summary>
        public SecurityWordsForOtpRequestDto()
        {
        }
    }
}