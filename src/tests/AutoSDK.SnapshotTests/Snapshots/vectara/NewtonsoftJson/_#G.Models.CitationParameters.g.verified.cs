//HintName: G.Models.CitationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Style the generator should use when making citations.
    /// </summary>
    public sealed partial class CitationParameters
    {
        /// <summary>
        /// The citation style that you want to use in the summary: <br/>
        /// * `numeric` - Citations formatted as simple numerals: \[1\], \[2\], etc.<br/>
        /// * `none` - Citations removed from text.<br/>
        /// * `html` - Citation formatted as a URL like `&lt;a href="url_pattern"&gt;text_pattern&lt;/a&gt;`.<br/>
        /// * `markdown` - Formatted as `[text_pattern](url_pattern)`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("style")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CitationParametersStyleJsonConverter))]
        public global::G.CitationParametersStyle? Style { get; set; }

        /// <summary>
        /// The URL pattern if the citation_style is set to `html` or `markdown`. The pattern can access metadata attributes in the document or part. e.g. `https://my.doc/foo/{doc.id}/{part.id}` The default `url_pattern` is an empty string.<br/>
        /// Example: https://vectara.com/documents/{doc.id}
        /// </summary>
        /// <example>https://vectara.com/documents/{doc.id}</example>
        [global::Newtonsoft.Json.JsonProperty("url_pattern")]
        public string? UrlPattern { get; set; }

        /// <summary>
        /// The text pattern if the citation_style is set to `html` or `markdown`. This pattern sets the href for HTML or the text within `[]` in markdown, and defaults to N being the index of result if it is not set. The default citation style looks like `[N](&lt;url_pattern&gt;)` for markdown. You can use metadata attributes in the `text_pattern`. For example, the pattern `{doc.title}` with citation style `markdown` would result in final citation output like `[Title](&lt;url_pattern&gt;)` when the document's metadata includes `{"title":"Title"}`.<br/>
        /// Example: {doc.title}
        /// </summary>
        /// <example>{doc.title}</example>
        [global::Newtonsoft.Json.JsonProperty("text_pattern")]
        public string? TextPattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationParameters" /> class.
        /// </summary>
        /// <param name="style">
        /// The citation style that you want to use in the summary: <br/>
        /// * `numeric` - Citations formatted as simple numerals: \[1\], \[2\], etc.<br/>
        /// * `none` - Citations removed from text.<br/>
        /// * `html` - Citation formatted as a URL like `&lt;a href="url_pattern"&gt;text_pattern&lt;/a&gt;`.<br/>
        /// * `markdown` - Formatted as `[text_pattern](url_pattern)`.
        /// </param>
        /// <param name="urlPattern">
        /// The URL pattern if the citation_style is set to `html` or `markdown`. The pattern can access metadata attributes in the document or part. e.g. `https://my.doc/foo/{doc.id}/{part.id}` The default `url_pattern` is an empty string.<br/>
        /// Example: https://vectara.com/documents/{doc.id}
        /// </param>
        /// <param name="textPattern">
        /// The text pattern if the citation_style is set to `html` or `markdown`. This pattern sets the href for HTML or the text within `[]` in markdown, and defaults to N being the index of result if it is not set. The default citation style looks like `[N](&lt;url_pattern&gt;)` for markdown. You can use metadata attributes in the `text_pattern`. For example, the pattern `{doc.title}` with citation style `markdown` would result in final citation output like `[Title](&lt;url_pattern&gt;)` when the document's metadata includes `{"title":"Title"}`.<br/>
        /// Example: {doc.title}
        /// </param>
        public CitationParameters(
            global::G.CitationParametersStyle? style,
            string? urlPattern,
            string? textPattern)
        {
            this.Style = style;
            this.UrlPattern = urlPattern;
            this.TextPattern = textPattern;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationParameters" /> class.
        /// </summary>
        public CitationParameters()
        {
        }
    }
}