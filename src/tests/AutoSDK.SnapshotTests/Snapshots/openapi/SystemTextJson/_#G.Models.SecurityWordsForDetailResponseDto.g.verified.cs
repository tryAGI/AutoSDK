//HintName: G.Models.SecurityWordsForDetailResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SecurityWordsForDetailResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("words")]
        public global::System.Collections.Generic.IList<string>? Words { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityWordsForDetailResponseDto" /> class.
        /// </summary>
        /// <param name="words"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecurityWordsForDetailResponseDto(
            global::System.Collections.Generic.IList<string>? words)
        {
            this.Words = words;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityWordsForDetailResponseDto" /> class.
        /// </summary>
        public SecurityWordsForDetailResponseDto()
        {
        }
    }
}