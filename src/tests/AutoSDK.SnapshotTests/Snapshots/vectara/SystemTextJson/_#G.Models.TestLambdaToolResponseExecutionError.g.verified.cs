//HintName: G.Models.TestLambdaToolResponseExecutionError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Error information if execution failed.
    /// </summary>
    public sealed partial class TestLambdaToolResponseExecutionError
    {
        /// <summary>
        /// The error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Stack trace for debugging.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceback")]
        public string? Traceback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLambdaToolResponseExecutionError" /> class.
        /// </summary>
        /// <param name="message">
        /// The error message.
        /// </param>
        /// <param name="traceback">
        /// Stack trace for debugging.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestLambdaToolResponseExecutionError(
            string? message,
            string? traceback)
        {
            this.Message = message;
            this.Traceback = traceback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLambdaToolResponseExecutionError" /> class.
        /// </summary>
        public TestLambdaToolResponseExecutionError()
        {
        }
    }
}