//HintName: G.Models.TestLastMileEvaluatorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestLastMileEvaluatorRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("testInput", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TestInput TestInput { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.LastMileConfigForm Config { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLastMileEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="testInput"></param>
        /// <param name="config"></param>
        public TestLastMileEvaluatorRequest(
            global::G.TestInput testInput,
            global::G.LastMileConfigForm config)
        {
            this.TestInput = testInput ?? throw new global::System.ArgumentNullException(nameof(testInput));
            this.Config = config;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestLastMileEvaluatorRequest" /> class.
        /// </summary>
        public TestLastMileEvaluatorRequest()
        {
        }
    }
}