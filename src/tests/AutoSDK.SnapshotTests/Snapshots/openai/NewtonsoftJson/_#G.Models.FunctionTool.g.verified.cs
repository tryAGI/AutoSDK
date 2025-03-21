//HintName: G.Models.FunctionTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines a function in your own code the model can choose to call. Learn more<br/>
    /// about [function calling](/docs/guides/function-calling).
    /// </summary>
    public sealed partial class FunctionTool
    {
        /// <summary>
        /// The type of the function tool. Always `function`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FunctionToolType Type { get; set; }

        /// <summary>
        /// The name of the function to call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A description of the function. Used by the model to determine whether<br/>
        /// or not to call the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A JSON schema object describing the parameters of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public object Parameters { get; set; } = default!;

        /// <summary>
        /// Whether to enforce strict parameter validation. Default `true`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Strict { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the function tool. Always `function`.
        /// </param>
        /// <param name="name">
        /// The name of the function to call.
        /// </param>
        /// <param name="description">
        /// A description of the function. Used by the model to determine whether<br/>
        /// or not to call the function.
        /// </param>
        /// <param name="parameters">
        /// A JSON schema object describing the parameters of the function.
        /// </param>
        /// <param name="strict">
        /// Whether to enforce strict parameter validation. Default `true`.
        /// </param>
        public FunctionTool(
            string name,
            object parameters,
            bool strict,
            global::G.FunctionToolType type,
            string? description)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Strict = strict;
            this.Type = type;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionTool" /> class.
        /// </summary>
        public FunctionTool()
        {
        }
    }
}