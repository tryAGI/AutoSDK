//HintName: G.Models.ChecksUpdateRequestOutputAnnotation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChecksUpdateRequestOutputAnnotation
    {
        /// <summary>
        /// The path of the file to add an annotation to. For example, `assets/css/main.css`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The start line of the annotation. Line numbers start at 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartLine { get; set; }

        /// <summary>
        /// The end line of the annotation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndLine { get; set; }

        /// <summary>
        /// The start column of the annotation. Annotations only support `start_column` and `end_column` on the same line. Omit this parameter if `start_line` and `end_line` have different values. Column numbers start at 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_column")]
        public int? StartColumn { get; set; }

        /// <summary>
        /// The end column of the annotation. Annotations only support `start_column` and `end_column` on the same line. Omit this parameter if `start_line` and `end_line` have different values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_column")]
        public int? EndColumn { get; set; }

        /// <summary>
        /// The level of the annotation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotation_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChecksUpdateRequestOutputAnnotationAnnotationLevelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChecksUpdateRequestOutputAnnotationAnnotationLevel AnnotationLevel { get; set; }

        /// <summary>
        /// A short description of the feedback for these lines of code. The maximum size is 64 KB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The title that represents the annotation. The maximum size is 255 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Details about this annotation. The maximum size is 64 KB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_details")]
        public string? RawDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksUpdateRequestOutputAnnotation" /> class.
        /// </summary>
        /// <param name="path">
        /// The path of the file to add an annotation to. For example, `assets/css/main.css`.
        /// </param>
        /// <param name="startLine">
        /// The start line of the annotation. Line numbers start at 1.
        /// </param>
        /// <param name="endLine">
        /// The end line of the annotation.
        /// </param>
        /// <param name="startColumn">
        /// The start column of the annotation. Annotations only support `start_column` and `end_column` on the same line. Omit this parameter if `start_line` and `end_line` have different values. Column numbers start at 1.
        /// </param>
        /// <param name="endColumn">
        /// The end column of the annotation. Annotations only support `start_column` and `end_column` on the same line. Omit this parameter if `start_line` and `end_line` have different values.
        /// </param>
        /// <param name="annotationLevel">
        /// The level of the annotation.
        /// </param>
        /// <param name="message">
        /// A short description of the feedback for these lines of code. The maximum size is 64 KB.
        /// </param>
        /// <param name="title">
        /// The title that represents the annotation. The maximum size is 255 characters.
        /// </param>
        /// <param name="rawDetails">
        /// Details about this annotation. The maximum size is 64 KB.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChecksUpdateRequestOutputAnnotation(
            string path,
            int startLine,
            int endLine,
            global::G.ChecksUpdateRequestOutputAnnotationAnnotationLevel annotationLevel,
            string message,
            int? startColumn,
            int? endColumn,
            string? title,
            string? rawDetails)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.StartLine = startLine;
            this.EndLine = endLine;
            this.AnnotationLevel = annotationLevel;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.StartColumn = startColumn;
            this.EndColumn = endColumn;
            this.Title = title;
            this.RawDetails = rawDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChecksUpdateRequestOutputAnnotation" /> class.
        /// </summary>
        public ChecksUpdateRequestOutputAnnotation()
        {
        }
    }
}