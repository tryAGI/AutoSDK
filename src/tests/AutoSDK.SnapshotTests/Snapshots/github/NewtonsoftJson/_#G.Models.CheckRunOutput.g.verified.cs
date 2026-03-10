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
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

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
            int annotationsCount,
            string annotationsUrl,
            string? title,
            string? summary,
            string? text)
        {
            this.AnnotationsCount = annotationsCount;
            this.AnnotationsUrl = annotationsUrl ?? throw new global::System.ArgumentNullException(nameof(annotationsUrl));
            this.Title = title;
            this.Summary = summary;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckRunOutput" /> class.
        /// </summary>
        public CheckRunOutput()
        {
        }
    }
}