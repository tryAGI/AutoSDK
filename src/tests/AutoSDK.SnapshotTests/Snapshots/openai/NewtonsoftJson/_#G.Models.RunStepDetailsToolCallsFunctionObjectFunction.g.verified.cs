//HintName: G.Models.RunStepDetailsToolCallsFunctionObjectFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The definition of the function that was called.
    /// </summary>
    public sealed partial class RunStepDetailsToolCallsFunctionObjectFunction
    {
        /// <summary>
        /// The arguments passed to the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments", Required = global::Newtonsoft.Json.Required.Always)]
        public string Arguments { get; set; } = default!;

        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The output of the function. This will be `null` if the outputs have not been [submitted](/docs/api-reference/runs/submitToolOutputs) yet.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Output { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFunctionObjectFunction" /> class.
        /// </summary>
        /// <param name="arguments">
        /// The arguments passed to the function.
        /// </param>
        /// <param name="name">
        /// The name of the function.
        /// </param>
        /// <param name="output">
        /// The output of the function. This will be `null` if the outputs have not been [submitted](/docs/api-reference/runs/submitToolOutputs) yet.
        /// </param>
        public RunStepDetailsToolCallsFunctionObjectFunction(
            string arguments,
            string name,
            string? output)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Output = output ?? throw new global::System.ArgumentNullException(nameof(output));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunStepDetailsToolCallsFunctionObjectFunction" /> class.
        /// </summary>
        public RunStepDetailsToolCallsFunctionObjectFunction()
        {
        }
    }
}