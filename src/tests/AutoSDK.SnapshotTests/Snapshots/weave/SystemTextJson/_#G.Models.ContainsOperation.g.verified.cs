//HintName: G.Models.ContainsOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Case-insensitive substring match.<br/>
    /// Not part of MongoDB. Weave-specific addition.<br/>
    /// Example:<br/>
    ///     ```<br/>
    ///     {<br/>
    ///         "$contains": {<br/>
    ///             "input": {"$getField": "display_name"},<br/>
    ///             "substr": {"$literal": "llm"},<br/>
    ///             "case_insensitive": true<br/>
    ///         }<br/>
    ///     }<br/>
    ///     ```
    /// </summary>
    public sealed partial class ContainsOperation
    {
        /// <summary>
        /// Specification for the `$contains` operation.<br/>
        /// - `input`: The string to search.<br/>
        /// - `substr`: The substring to search for.<br/>
        /// - `case_insensitive`: If true, match is case-insensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("$contains")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ContainsSpec x_contains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsOperation" /> class.
        /// </summary>
        /// <param name="x_contains">
        /// Specification for the `$contains` operation.<br/>
        /// - `input`: The string to search.<br/>
        /// - `substr`: The substring to search for.<br/>
        /// - `case_insensitive`: If true, match is case-insensitive.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainsOperation(
            global::G.ContainsSpec x_contains)
        {
            this.x_contains = x_contains ?? throw new global::System.ArgumentNullException(nameof(x_contains));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainsOperation" /> class.
        /// </summary>
        public ContainsOperation()
        {
        }
    }
}