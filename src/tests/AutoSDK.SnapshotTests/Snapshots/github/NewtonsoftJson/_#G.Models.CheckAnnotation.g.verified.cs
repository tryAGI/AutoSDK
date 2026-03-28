//HintName: G.Models.CheckAnnotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Check Annotation
    /// </summary>
    public sealed partial class CheckAnnotation
    {
        /// <summary>
        /// Example: README.md
        /// </summary>
        /// <example>README.md</example>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("start_line", Required = global::Newtonsoft.Json.Required.Always)]
        public int StartLine { get; set; } = default!;

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::Newtonsoft.Json.JsonProperty("end_line", Required = global::Newtonsoft.Json.Required.Always)]
        public int EndLine { get; set; } = default!;

        /// <summary>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("start_column")]
        public int? StartColumn { get; set; }

        /// <summary>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("end_column")]
        public int? EndColumn { get; set; }

        /// <summary>
        /// Example: warning
        /// </summary>
        /// <example>warning</example>
        [global::Newtonsoft.Json.JsonProperty("annotation_level")]
        public string? AnnotationLevel { get; set; }

        /// <summary>
        /// Example: Spell Checker
        /// </summary>
        /// <example>Spell Checker</example>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Example: Check your spelling for 'banaas'.
        /// </summary>
        /// <example>Check your spelling for 'banaas'.</example>
        [global::Newtonsoft.Json.JsonProperty("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: Do you mean 'bananas' or 'banana'?
        /// </summary>
        /// <example>Do you mean 'bananas' or 'banana'?</example>
        [global::Newtonsoft.Json.JsonProperty("raw_details")]
        public string? RawDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blob_href", Required = global::Newtonsoft.Json.Required.Always)]
        public string BlobHref { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAnnotation" /> class.
        /// </summary>
        /// <param name="path">
        /// Example: README.md
        /// </param>
        /// <param name="startLine">
        /// Example: 2
        /// </param>
        /// <param name="endLine">
        /// Example: 2
        /// </param>
        /// <param name="blobHref"></param>
        /// <param name="startColumn">
        /// Example: 5
        /// </param>
        /// <param name="endColumn">
        /// Example: 10
        /// </param>
        /// <param name="annotationLevel">
        /// Example: warning
        /// </param>
        /// <param name="title">
        /// Example: Spell Checker
        /// </param>
        /// <param name="message">
        /// Example: Check your spelling for 'banaas'.
        /// </param>
        /// <param name="rawDetails">
        /// Example: Do you mean 'bananas' or 'banana'?
        /// </param>
        public CheckAnnotation(
            string path,
            int startLine,
            int endLine,
            string blobHref,
            int? startColumn,
            int? endColumn,
            string? annotationLevel,
            string? title,
            string? message,
            string? rawDetails)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.StartLine = startLine;
            this.EndLine = endLine;
            this.StartColumn = startColumn;
            this.EndColumn = endColumn;
            this.AnnotationLevel = annotationLevel;
            this.Title = title;
            this.Message = message;
            this.RawDetails = rawDetails;
            this.BlobHref = blobHref ?? throw new global::System.ArgumentNullException(nameof(blobHref));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAnnotation" /> class.
        /// </summary>
        public CheckAnnotation()
        {
        }
    }
}