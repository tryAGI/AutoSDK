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
        [global::Newtonsoft.Json.JsonProperty("line", Required = global::Newtonsoft.Json.Required.Always)]
        public int Line { get; set; } = default!;

        /// <summary>
        /// The column number where this errors occurs.<br/>
        /// Example: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("column", Required = global::Newtonsoft.Json.Required.Always)]
        public int Column { get; set; } = default!;

        /// <summary>
        /// The contents of the line where the error occurs.<br/>
        /// Example: * user
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// The type of error.<br/>
        /// Example: Invalid owner
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("kind", Required = global::Newtonsoft.Json.Required.Always)]
        public string Kind { get; set; } = default!;

        /// <summary>
        /// Suggested action to fix the error. This will usually be `null`, but is provided for some common errors.<br/>
        /// Example: The pattern `/` will never match anything, did you mean `*` instead?
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suggestion")]
        public string? Suggestion { get; set; }

        /// <summary>
        /// A human-readable description of the error, combining information from multiple fields, laid out for display in a monospaced typeface (for example, a command-line setting).<br/>
        /// Example: Invalid owner on line 7:<br/>
        ///   * user<br/>
        ///     ^
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The path of the file where the error occured.<br/>
        /// Example: .github/CODEOWNERS
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}