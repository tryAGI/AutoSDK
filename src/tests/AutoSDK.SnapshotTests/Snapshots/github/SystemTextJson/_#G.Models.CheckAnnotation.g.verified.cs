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
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartLine { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndLine { get; set; }

        /// <summary>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_column")]
        public int? StartColumn { get; set; }

        /// <summary>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_column")]
        public int? EndColumn { get; set; }

        /// <summary>
        /// Example: warning
        /// </summary>
        /// <example>warning</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_level")]
        public string? AnnotationLevel { get; set; }

        /// <summary>
        /// Example: Spell Checker
        /// </summary>
        /// <example>Spell Checker</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Example: Check your spelling for 'banaas'.
        /// </summary>
        /// <example>Check your spelling for 'banaas'.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Example: Do you mean 'bananas' or 'banana'?
        /// </summary>
        /// <example>Do you mean 'bananas' or 'banana'?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_details")]
        public string? RawDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blob_href")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BlobHref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        /// <param name="blobHref"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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
            this.BlobHref = blobHref ?? throw new global::System.ArgumentNullException(nameof(blobHref));
            this.StartColumn = startColumn;
            this.EndColumn = endColumn;
            this.AnnotationLevel = annotationLevel;
            this.Title = title;
            this.Message = message;
            this.RawDetails = rawDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckAnnotation" /> class.
        /// </summary>
        public CheckAnnotation()
        {
        }
    }
}