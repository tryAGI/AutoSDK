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
        [global::Newtonsoft.Json.JsonProperty("testInput", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TestInput TestInput { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestPythonEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="testInput"></param>
        /// <param name="code"></param>
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