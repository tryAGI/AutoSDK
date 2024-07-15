//HintName: G.Models.CodeownersErrorsErrors.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CodeownersErrorsErrors
    {
        /// <summary>
        /// The line number where this errors occurs.<br/>
        /// Example: 7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Line { get; set; }

        /// <summary>
        /// The column number where this errors occurs.<br/>
        /// Example: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Column { get; set; }

        /// <summary>
        /// The contents of the line where the error occurs.<br/>
        /// Example: * user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// The type of error.<br/>
        /// Example: Invalid owner
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Kind { get; set; }

        /// <summary>
        /// Suggested action to fix the error. This will usually be `null`, but is provided for some common errors.<br/>
        /// Example: The pattern `/` will never match anything, did you mean `*` instead?
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suggestion")]
        public string? Suggestion { get; set; }

        /// <summary>
        /// A human-readable description of the error, combining information from multiple fields, laid out for display in a monospaced typeface (for example, a command-line setting).<br/>
        /// Example: Invalid owner on line 7:<br/>
        ///   * user<br/>
        ///     ^
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The path of the file where the error occured.<br/>
        /// Example: .github/CODEOWNERS
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}