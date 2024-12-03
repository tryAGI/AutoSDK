//HintName: G.Models.RunStepDeltaStepDetailsToolCallsFunctionObjectFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The definition of the function that was called.
    /// </summary>
    public sealed partial class RunStepDeltaStepDetailsToolCallsFunctionObjectFunction
    {
        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The arguments passed to the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// The output of the function. This will be `null` if the outputs have not been [submitted](/docs/api-reference/runs/submitToolOutputs) yet.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output")]
        public string? Output { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsFunctionObjectFunction" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function.
        /// </param>
        /// <param name="arguments">
        /// The arguments passed to the function.
        /// </param>
        /// <param name="output">
        /// The output of the function. This will be `null` if the outputs have not been [submitted](/docs/api-reference/runs/submitToolOutputs) yet.
        /// </param>
        public RunStepDeltaStepDetailsToolCallsFunctionObjectFunction(
            string? name,
            string? arguments,
            string? output)
        {
            this.Name = name;
            this.Arguments = arguments;
            this.Output = output;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDeltaStepDetailsToolCallsFunctionObjectFunction" /> class.
        /// </summary>
        public RunStepDeltaStepDetailsToolCallsFunctionObjectFunction()
        {
        }
    }
}