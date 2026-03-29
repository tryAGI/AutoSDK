//HintName: G.Models.ScrapeResponseData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScrapeResponseData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public string? Markdown { get; set; }

        /// <summary>
        /// HTML version of the content on page if `html` is in `formats`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html")]
        public string? Html { get; set; }

        /// <summary>
        /// Raw HTML content of the page if `rawHtml` is in `formats`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rawHtml")]
        public string? RawHtml { get; set; }

        /// <summary>
        /// Screenshot of the page if `screenshot` is in `formats`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("screenshot")]
        public string? Screenshot { get; set; }

        /// <summary>
        /// List of links on the page if `links` is in `formats`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links")]
        public global::System.Collections.Generic.IList<string>? Links { get; set; }

        /// <summary>
        /// Results of the actions specified in the `actions` parameter. Only present if the `actions` parameter was provided in the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actions")]
        public global::G.ScrapeResponseDataActions? Actions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.ScrapeResponseDataMetadata? Metadata { get; set; }

        /// <summary>
        /// Displayed when using LLM Extraction. Extracted data from the page following the schema defined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_extraction")]
        public object? LlmExtraction { get; set; }

        /// <summary>
        /// Can be displayed when using LLM Extraction. Warning message will let you know any issues with the extraction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warning")]
        public string? Warning { get; set; }

        /// <summary>
        /// Change tracking information if `changeTracking` is in `formats`. Only present when the `changeTracking` format is requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changeTracking")]
        public global::G.ScrapeResponseDataChangeTracking? ChangeTracking { get; set; }

        /// <summary>
        /// Brand identity information derived from executing on-page javascript.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branding")]
        public global::G.ScrapeResponseDataBranding? Branding { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeResponseData" /> class.
        /// </summary>
        /// <param name="markdown"></param>
        /// <param name="html">
        /// HTML version of the content on page if `html` is in `formats`
        /// </param>
        /// <param name="rawHtml">
        /// Raw HTML content of the page if `rawHtml` is in `formats`
        /// </param>
        /// <param name="screenshot">
        /// Screenshot of the page if `screenshot` is in `formats`
        /// </param>
        /// <param name="links">
        /// List of links on the page if `links` is in `formats`
        /// </param>
        /// <param name="actions">
        /// Results of the actions specified in the `actions` parameter. Only present if the `actions` parameter was provided in the request
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="llmExtraction">
        /// Displayed when using LLM Extraction. Extracted data from the page following the schema defined.
        /// </param>
        /// <param name="warning">
        /// Can be displayed when using LLM Extraction. Warning message will let you know any issues with the extraction.
        /// </param>
        /// <param name="changeTracking">
        /// Change tracking information if `changeTracking` is in `formats`. Only present when the `changeTracking` format is requested.
        /// </param>
        /// <param name="branding">
        /// Brand identity information derived from executing on-page javascript.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScrapeResponseData(
            string? markdown,
            string? html,
            string? rawHtml,
            string? screenshot,
            global::System.Collections.Generic.IList<string>? links,
            global::G.ScrapeResponseDataActions? actions,
            global::G.ScrapeResponseDataMetadata? metadata,
            object? llmExtraction,
            string? warning,
            global::G.ScrapeResponseDataChangeTracking? changeTracking,
            global::G.ScrapeResponseDataBranding? branding)
        {
            this.Markdown = markdown;
            this.Html = html;
            this.RawHtml = rawHtml;
            this.Screenshot = screenshot;
            this.Links = links;
            this.Actions = actions;
            this.Metadata = metadata;
            this.LlmExtraction = llmExtraction;
            this.Warning = warning;
            this.ChangeTracking = changeTracking;
            this.Branding = branding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeResponseData" /> class.
        /// </summary>
        public ScrapeResponseData()
        {
        }
    }
}