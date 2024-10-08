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
        /// The citation style to be used in summary.<br/>
        /// Can be one of:<br/>
        /// * `numeric` - Citations formatted as simple numerals: \[1\], \[2\] ...<br/>
        /// * `none` - Citations removed from text.<br/>
        /// * `html` - Citation formatted as a URL like `&lt;a href="url_pattern"&gt;text_pattern&lt;/a&gt;`.<br/>
        /// * `markdown` - Formatted as `[text_pattern](url_pattern)`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("style")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CitationParametersStyleJsonConverter))]
        public global::G.CitationParametersStyle? Style { get; set; }

        /// <summary>
        /// The URL pattern if the citation_style is set to `html` or `markdown`.<br/>
        /// The pattern can access metadata attributes in the document or part.<br/>
        /// e.g. `https://my.doc/foo/{doc.id}/{part.id}`<br/>
        /// The default `url_pattern` is an empty string.<br/>
        /// Example: https://vectara.com/documents/{doc.id}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url_pattern")]
        public string? UrlPattern { get; set; }

        /// <summary>
        /// The text pattern if the citation_style is set to `html` or `markdown`.<br/>
        /// This pattern sets the href for HTML or the text within `[]` in markdown,<br/>
        /// and defaults to N being the index of result if it is not set.<br/>
        /// The default citation style looks like `[N](&lt;url_pattern&gt;)` for markdown.<br/>
        /// You can use metadata attributes in the `text_pattern`. For example,<br/>
        /// the pattern `{doc.title}` with citation style `markdown` would result<br/>
        /// in final citation output like `[Title](&lt;url_pattern&gt;)` when<br/>
        /// the document's metadata includes `{"title":"Title"}`.<br/>
        /// Example: {doc.title}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_pattern")]
        public string? TextPattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}