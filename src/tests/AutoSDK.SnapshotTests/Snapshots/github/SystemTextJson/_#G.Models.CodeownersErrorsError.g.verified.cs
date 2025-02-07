//HintName: G.Models.CodeownersErrorsError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeownersErrorsError
    {
        /// <summary>
        /// The line number where this errors occurs.<br/>
        /// Example: 7
        /// </summary>
        /// <example>7</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Line { get; set; }

        /// <summary>
        /// The column number where this errors occurs.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Column { get; set; }

        /// <summary>
        /// The contents of the line where the error occurs.<br/>
        /// Example: * user
        /// </summary>
        /// <example>* user</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// The type of error.<br/>
        /// Example: Invalid owner
        /// </summary>
        /// <example>Invalid owner</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// Suggested action to fix the error. This will usually be `null`, but is provided for some common errors.<br/>
        /// Example: The pattern `/` will never match anything, did you mean `*` instead?
        /// </summary>
        /// <example>The pattern `/` will never match anything, did you mean `*` instead?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestion")]
        public string? Suggestion { get; set; }

        /// <summary>
        /// A human-readable description of the error, combining information from multiple fields, laid out for display in a monospaced typeface (for example, a command-line setting).<br/>
        /// Example: Invalid owner on line 7:<br/>
        ///   * user<br/>
        ///     ^
        /// </summary>
        /// <example>
        /// Invalid owner on line 7:<br/>
        ///   * user<br/>
        ///     ^
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The path of the file where the error occured.<br/>
        /// Example: .github/CODEOWNERS
        /// </summary>
        /// <example>.github/CODEOWNERS</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeownersErrorsError" /> class.
        /// </summary>
        /// <param name="line">
        /// The line number where this errors occurs.<br/>
        /// Example: 7
        /// </param>
        /// <param name="column">
        /// The column number where this errors occurs.<br/>
        /// Example: 3
        /// </param>
        /// <param name="source">
        /// The contents of the line where the error occurs.<br/>
        /// Example: * user
        /// </param>
        /// <param name="kind">
        /// The type of error.<br/>
        /// Example: Invalid owner
        /// </param>
        /// <param name="suggestion">
        /// Suggested action to fix the error. This will usually be `null`, but is provided for some common errors.<br/>
        /// Example: The pattern `/` will never match anything, did you mean `*` instead?
        /// </param>
        /// <param name="message">
        /// A human-readable description of the error, combining information from multiple fields, laid out for display in a monospaced typeface (for example, a command-line setting).<br/>
        /// Example: Invalid owner on line 7:<br/>
        ///   * user<br/>
        ///     ^
        /// </param>
        /// <param name="path">
        /// The path of the file where the error occured.<br/>
        /// Example: .github/CODEOWNERS
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CodeownersErrorsError(
            int line,
            int column,
            string kind,
            string message,
            string path,
            string? source,
            string? suggestion)
        {
            this.Line = line;
            this.Column = column;
            this.Kind = kind ?? throw new global::System.ArgumentNullException(nameof(kind));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Source = source;
            this.Suggestion = suggestion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeownersErrorsError" /> class.
        /// </summary>
        public CodeownersErrorsError()
        {
        }
    }
}