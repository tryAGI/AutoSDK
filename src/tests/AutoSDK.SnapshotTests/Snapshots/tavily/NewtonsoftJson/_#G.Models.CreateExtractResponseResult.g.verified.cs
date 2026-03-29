//HintName: G.Models.CreateExtractResponseResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateExtractResponseResult
    {
        /// <summary>
        /// The URL from which the content was extracted.<br/>
        /// Example: https://en.wikipedia.org/wiki/Artificial_intelligence
        /// </summary>
        /// <example>https://en.wikipedia.org/wiki/Artificial_intelligence</example>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The full content extracted from the page. When `query` is provided, contains the top-ranked chunks joined by `[...]` separator.<br/>
        /// Example: "Jump to content\nMain menu\nSearch\nAppearance\nDonate\nCreate account\nLog in\nPersonal tools\n        Photograph your local culture, help Wikipedia and win!\nToggle the table of contents\nArtificial intelligence\n161 languages\nArticle\nTalk\nRead\nView source\nView history\nTools\nFrom Wikipedia, the free encyclopedia\n\"AI\" redirects here. For other uses, see AI (disambiguation) and Artificial intelligence (disambiguation).\nPart of a series on\nArtificial intelligence (AI)\nshow\nMajor goals\nshow\nApproaches\nshow\nApplications\nshow\nPhilosophy\nshow\nHistory\nshow\nGlossary\nvte\nArtificial intelligence (AI), in its broadest sense, is intelligence exhibited by machines, particularly computer systems. It is a field of research in computer science that develops and studies methods and software that enable machines to perceive their environment and use learning and intelligence to take actions that maximize their chances of achieving defined goals.[1] Such machines may be called AIs.\nHigh-profile applications of AI include advanced web search engines (e.g., Google Search); recommendation systems (used by YouTube, Amazon, and Netflix); virtual assistants (e.g., Google Assistant, Siri, and Alexa); autonomous vehicles (e.g., Waymo); generative and creative tools (e.g., ChatGPT and AI art); and superhuman play and analysis in strategy games (e.g., chess and Go)...................
        /// </summary>
        /// <example>"Jump to content\nMain menu\nSearch\nAppearance\nDonate\nCreate account\nLog in\nPersonal tools\n        Photograph your local culture, help Wikipedia and win!\nToggle the table of contents\nArtificial intelligence\n161 languages\nArticle\nTalk\nRead\nView source\nView history\nTools\nFrom Wikipedia, the free encyclopedia\n\"AI\" redirects here. For other uses, see AI (disambiguation) and Artificial intelligence (disambiguation).\nPart of a series on\nArtificial intelligence (AI)\nshow\nMajor goals\nshow\nApproaches\nshow\nApplications\nshow\nPhilosophy\nshow\nHistory\nshow\nGlossary\nvte\nArtificial intelligence (AI), in its broadest sense, is intelligence exhibited by machines, particularly computer systems. It is a field of research in computer science that develops and studies methods and software that enable machines to perceive their environment and use learning and intelligence to take actions that maximize their chances of achieving defined goals.[1] Such machines may be called AIs.\nHigh-profile applications of AI include advanced web search engines (e.g., Google Search); recommendation systems (used by YouTube, Amazon, and Netflix); virtual assistants (e.g., Google Assistant, Siri, and Alexa); autonomous vehicles (e.g., Waymo); generative and creative tools (e.g., ChatGPT and AI art); and superhuman play and analysis in strategy games (e.g., chess and Go)...................</example>
        [global::Newtonsoft.Json.JsonProperty("raw_content")]
        public string? RawContent { get; set; }

        /// <summary>
        /// This is only available if `include_images` is set to `true`. A list of image URLs extracted from the page.<br/>
        /// Example: []
        /// </summary>
        /// <example>[]</example>
        [global::Newtonsoft.Json.JsonProperty("images")]
        public global::System.Collections.Generic.IList<string>? Images { get; set; }

        /// <summary>
        /// The favicon URL for the result.<br/>
        /// Example: https://en.wikipedia.org/static/favicon/wikipedia.ico
        /// </summary>
        /// <example>https://en.wikipedia.org/static/favicon/wikipedia.ico</example>
        [global::Newtonsoft.Json.JsonProperty("favicon")]
        public string? Favicon { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExtractResponseResult" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL from which the content was extracted.<br/>
        /// Example: https://en.wikipedia.org/wiki/Artificial_intelligence
        /// </param>
        /// <param name="rawContent">
        /// The full content extracted from the page. When `query` is provided, contains the top-ranked chunks joined by `[...]` separator.<br/>
        /// Example: "Jump to content\nMain menu\nSearch\nAppearance\nDonate\nCreate account\nLog in\nPersonal tools\n        Photograph your local culture, help Wikipedia and win!\nToggle the table of contents\nArtificial intelligence\n161 languages\nArticle\nTalk\nRead\nView source\nView history\nTools\nFrom Wikipedia, the free encyclopedia\n\"AI\" redirects here. For other uses, see AI (disambiguation) and Artificial intelligence (disambiguation).\nPart of a series on\nArtificial intelligence (AI)\nshow\nMajor goals\nshow\nApproaches\nshow\nApplications\nshow\nPhilosophy\nshow\nHistory\nshow\nGlossary\nvte\nArtificial intelligence (AI), in its broadest sense, is intelligence exhibited by machines, particularly computer systems. It is a field of research in computer science that develops and studies methods and software that enable machines to perceive their environment and use learning and intelligence to take actions that maximize their chances of achieving defined goals.[1] Such machines may be called AIs.\nHigh-profile applications of AI include advanced web search engines (e.g., Google Search); recommendation systems (used by YouTube, Amazon, and Netflix); virtual assistants (e.g., Google Assistant, Siri, and Alexa); autonomous vehicles (e.g., Waymo); generative and creative tools (e.g., ChatGPT and AI art); and superhuman play and analysis in strategy games (e.g., chess and Go)...................
        /// </param>
        /// <param name="images">
        /// This is only available if `include_images` is set to `true`. A list of image URLs extracted from the page.<br/>
        /// Example: []
        /// </param>
        /// <param name="favicon">
        /// The favicon URL for the result.<br/>
        /// Example: https://en.wikipedia.org/static/favicon/wikipedia.ico
        /// </param>
        public CreateExtractResponseResult(
            string? url,
            string? rawContent,
            global::System.Collections.Generic.IList<string>? images,
            string? favicon)
        {
            this.Url = url;
            this.RawContent = rawContent;
            this.Images = images;
            this.Favicon = favicon;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateExtractResponseResult" /> class.
        /// </summary>
        public CreateExtractResponseResult()
        {
        }
    }
}