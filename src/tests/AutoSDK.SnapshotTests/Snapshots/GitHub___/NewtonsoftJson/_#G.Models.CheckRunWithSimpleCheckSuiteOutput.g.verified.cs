//HintName: G.Models.CheckRunWithSimpleCheckSuiteOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckRunWithSimpleCheckSuiteOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int AnnotationsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AnnotationsUrl { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Summary { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Text { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Title { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckRunWithSimpleCheckSuiteOutput" /> class.
        /// </summary>
        /// <param name="annotationsCount"></param>
        /// <param name="annotationsUrl"></param>
        /// <param name="summary"></param>
        /// <param name="text"></param>
        /// <param name="title"></param>
        public CheckRunWithSimpleCheckSuiteOutput(
            int annotationsCount,
            string annotationsUrl,
            string? summary,
            string? text,
            string? title)
        {
            this.AnnotationsCount = annotationsCount;
            this.AnnotationsUrl = annotationsUrl ?? throw new global::System.ArgumentNullException(nameof(annotationsUrl));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckRunWithSimpleCheckSuiteOutput" /> class.
        /// </summary>
        public CheckRunWithSimpleCheckSuiteOutput()
        {
        }
    }
}