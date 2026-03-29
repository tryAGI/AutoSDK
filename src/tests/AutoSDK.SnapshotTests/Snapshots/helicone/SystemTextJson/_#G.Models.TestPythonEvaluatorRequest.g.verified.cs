//HintName: G.Models.TestPythonEvaluatorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestPythonEvaluatorRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testInput")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TestInput TestInput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestPythonEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="testInput"></param>
        /// <param name="code"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestPythonEvaluatorRequest(
            global::G.TestInput testInput,
            string code)
        {
            this.TestInput = testInput ?? throw new global::System.ArgumentNullException(nameof(testInput));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestPythonEvaluatorRequest" /> class.
        /// </summary>
        public TestPythonEvaluatorRequest()
        {
        }
    }
}