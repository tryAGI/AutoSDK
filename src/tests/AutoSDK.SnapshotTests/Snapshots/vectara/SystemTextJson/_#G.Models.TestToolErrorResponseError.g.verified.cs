//HintName: G.Models.TestToolErrorResponseError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error information from the failed execution.
    /// </summary>
    public sealed partial class TestToolErrorResponseError
    {
        /// <summary>
        /// The error message.<br/>
        /// Example: ValueError: Input must be positive
        /// </summary>
        /// <example>ValueError: Input must be positive</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Stack trace for debugging.<br/>
        /// Example: Traceback (most recent call last):<br/>
        ///   File "&lt;string&gt;", line 3, in process<br/>
        /// ValueError: Input must be positive
        /// </summary>
        /// <example>
        /// Traceback (most recent call last):<br/>
        ///   File "&lt;string&gt;", line 3, in process<br/>
        /// ValueError: Input must be positive
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceback")]
        public string? Traceback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestToolErrorResponseError" /> class.
        /// </summary>
        /// <param name="message">
        /// The error message.<br/>
        /// Example: ValueError: Input must be positive
        /// </param>
        /// <param name="traceback">
        /// Stack trace for debugging.<br/>
        /// Example: Traceback (most recent call last):<br/>
        ///   File "&lt;string&gt;", line 3, in process<br/>
        /// ValueError: Input must be positive
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestToolErrorResponseError(
            string message,
            string? traceback)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Traceback = traceback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestToolErrorResponseError" /> class.
        /// </summary>
        public TestToolErrorResponseError()
        {
        }
    }
}