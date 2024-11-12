//HintName: G.Models.ToolsPartFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsPartFunction
    {
        /// <summary>
        /// Example: A description of the function.
        /// </summary>
        /// <example>A description of the function.</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Example: function_name
        /// </summary>
        /// <example>function_name</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A map of parameter names to their values.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsPartFunction" /> class.
        /// </summary>
        /// <param name="description">
        /// Example: A description of the function.
        /// </param>
        /// <param name="name">
        /// Example: function_name
        /// </param>
        /// <param name="parameters">
        /// A map of parameter names to their values.
        /// </param>
        public ToolsPartFunction(
            string? description,
            string? name,
            object? parameters)
        {
            this.Description = description;
            this.Name = name;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsPartFunction" /> class.
        /// </summary>
        public ToolsPartFunction()
        {
        }
    }
}