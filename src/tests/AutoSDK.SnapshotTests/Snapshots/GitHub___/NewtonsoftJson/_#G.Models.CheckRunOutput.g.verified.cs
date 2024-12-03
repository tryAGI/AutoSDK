//HintName: G.Models.CheckRunOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CheckRunOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("title", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Title { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("annotations_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int AnnotationsCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AnnotationsUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckRunOutput" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="summary"></param>
        /// <param name="text"></param>
        /// <param name="annotationsCount"></param>
        /// <param name="annotationsUrl"></param>
        public CheckRunOutput(
            string? title,
            string? summary,
            string? text,
            int annotationsCount,
            string annotationsUrl)
        {
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.AnnotationsCount = annotationsCount;
            this.AnnotationsUrl = annotationsUrl ?? throw new global::System.ArgumentNullException(nameof(annotationsUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckRunOutput" /> class.
        /// </summary>
        public CheckRunOutput()
        {
        }
    }
}