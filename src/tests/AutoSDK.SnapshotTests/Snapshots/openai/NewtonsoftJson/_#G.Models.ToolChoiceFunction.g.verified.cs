//HintName: G.Models.ToolChoiceFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Use this option to force the model to call a specific function.
    /// </summary>
    public sealed partial class ToolChoiceFunction
    {
        /// <summary>
        /// For function calling, the type is always `function`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ToolChoiceFunctionType Type { get; set; }

        /// <summary>
        /// The name of the function to call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceFunction" /> class.
        /// </summary>
        /// <param name="type">
        /// For function calling, the type is always `function`.
        /// </param>
        /// <param name="name">
        /// The name of the function to call.
        /// </param>
        public ToolChoiceFunction(
            string name,
            global::G.ToolChoiceFunctionType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoiceFunction" /> class.
        /// </summary>
        public ToolChoiceFunction()
        {
        }
    }
}