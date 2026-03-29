//HintName: G.Models.CharacterCount.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CharacterCount
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_source_text_length")]
        public int? TotalSourceTextLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_translated_text_length")]
        public int? TotalTranslatedTextLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterCount" /> class.
        /// </summary>
        /// <param name="totalSourceTextLength"></param>
        /// <param name="totalTranslatedTextLength"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CharacterCount(
            int? totalSourceTextLength,
            int? totalTranslatedTextLength)
        {
            this.TotalSourceTextLength = totalSourceTextLength;
            this.TotalTranslatedTextLength = totalTranslatedTextLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterCount" /> class.
        /// </summary>
        public CharacterCount()
        {
        }
    }
}