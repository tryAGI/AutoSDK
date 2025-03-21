//HintName: G.Models.RunToolCallObjectFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The function definition.
    /// </summary>
    public sealed partial class RunToolCallObjectFunction
    {
        /// <summary>
        /// The arguments that the model expects you to pass to the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("arguments", Required = global::Newtonsoft.Json.Required.Always)]
        public string Arguments { get; set; } = default!;

        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunToolCallObjectFunction" /> class.
        /// </summary>
        /// <param name="arguments">
        /// The arguments that the model expects you to pass to the function.
        /// </param>
        /// <param name="name">
        /// The name of the function.
        /// </param>
        public RunToolCallObjectFunction(
            string arguments,
            string name)
        {
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunToolCallObjectFunction" /> class.
        /// </summary>
        public RunToolCallObjectFunction()
        {
        }
    }
}