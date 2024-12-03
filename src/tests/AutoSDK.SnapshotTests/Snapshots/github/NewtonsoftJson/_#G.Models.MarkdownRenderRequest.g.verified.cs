//HintName: G.Models.MarkdownRenderRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarkdownRenderRequest
    {
        /// <summary>
        /// The Markdown text to render in HTML.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// The rendering mode.<br/>
        /// Default Value: markdown<br/>
        /// Example: markdown
        /// </summary>
        /// <example>markdown</example>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public global::G.MarkdownRenderRequestMode? Mode { get; set; }

        /// <summary>
        /// The repository context to use when creating references in `gfm` mode.  For example, setting `context` to `octo-org/octo-repo` will change the text `#42` into an HTML link to issue 42 in the `octo-org/octo-repo` repository.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownRenderRequest" /> class.
        /// </summary>
        /// <param name="text">
        /// The Markdown text to render in HTML.
        /// </param>
        /// <param name="mode">
        /// The rendering mode.<br/>
        /// Default Value: markdown<br/>
        /// Example: markdown
        /// </param>
        /// <param name="context">
        /// The repository context to use when creating references in `gfm` mode.  For example, setting `context` to `octo-org/octo-repo` will change the text `#42` into an HTML link to issue 42 in the `octo-org/octo-repo` repository.
        /// </param>
        public MarkdownRenderRequest(
            string text,
            global::G.MarkdownRenderRequestMode? mode,
            string? context)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Mode = mode;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarkdownRenderRequest" /> class.
        /// </summary>
        public MarkdownRenderRequest()
        {
        }
    }
}