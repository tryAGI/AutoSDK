//HintName: G.Models.ToolFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A tool that uses a custom function.
    /// </summary>
    public sealed partial class ToolFunction
    {
        /// <summary>
        /// Description of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Name of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The parameters of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolFunction" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the function.
        /// </param>
        /// <param name="description">
        /// Description of the function.
        /// </param>
        /// <param name="parameters">
        /// The parameters of the function.
        /// </param>
        public ToolFunction(
            string name,
            string? description,
            object? parameters)
        {
            this.Description = description;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolFunction" /> class.
        /// </summary>
        public ToolFunction()
        {
        }
    }
}