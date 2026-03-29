//HintName: G.Models.FunctionDefinition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FunctionDefinition
    {
        /// <summary>
        /// The name of the function to be called.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A description of what the function does.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The parameters the function accepts, described as a JSON Schema object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDefinition" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function to be called.
        /// </param>
        /// <param name="description">
        /// A description of what the function does.
        /// </param>
        /// <param name="parameters">
        /// The parameters the function accepts, described as a JSON Schema object.
        /// </param>
        public FunctionDefinition(
            string name,
            string? description,
            object? parameters)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionDefinition" /> class.
        /// </summary>
        public FunctionDefinition()
        {
        }
    }
}