//HintName: G.Models.ToolFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolFunction
    {
        /// <summary>
        /// Name of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Description of the function.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// JSON Schema defining the function parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public object Parameters { get; set; } = default!;

        /// <summary>
        /// Whether strict mode is enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

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
        /// <param name="parameters">
        /// JSON Schema defining the function parameters.
        /// </param>
        /// <param name="description">
        /// Description of the function.
        /// </param>
        /// <param name="strict">
        /// Whether strict mode is enabled.
        /// </param>
        public ToolFunction(
            string name,
            object parameters,
            string? description,
            bool? strict)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolFunction" /> class.
        /// </summary>
        public ToolFunction()
        {
        }
    }
}