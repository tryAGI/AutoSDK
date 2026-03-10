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
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AnnotationsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AnnotationsUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckRunOutput" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="summary"></param>
        /// <param name="text"></param>
        /// <param name="annotationsCount"></param>
        /// <param name="annotationsUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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