//HintName: G.Models.ContentsRequestText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Advanced options for controlling text extraction. Use this when you need to limit text length or include HTML structure.
    /// </summary>
    public sealed partial class ContentsRequestText
    {
        /// <summary>
        /// Maximum character limit for the full page text. Useful for controlling response size and API costs.<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxCharacters")]
        public int? MaxCharacters { get; set; }

        /// <summary>
        /// Include HTML tags in the response, which can help LLMs understand text structure and formatting.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeHtmlTags")]
        public bool? IncludeHtmlTags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestText" /> class.
        /// </summary>
        /// <param name="maxCharacters">
        /// Maximum character limit for the full page text. Useful for controlling response size and API costs.<br/>
        /// Example: 1000
        /// </param>
        /// <param name="includeHtmlTags">
        /// Include HTML tags in the response, which can help LLMs understand text structure and formatting.<br/>
        /// Default Value: false<br/>
        /// Example: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentsRequestText(
            int? maxCharacters,
            bool? includeHtmlTags)
        {
            this.MaxCharacters = maxCharacters;
            this.IncludeHtmlTags = includeHtmlTags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentsRequestText" /> class.
        /// </summary>
        public ContentsRequestText()
        {
        }
    }
}