//HintName: G.Models.FunctionTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines a function in your own code the model can choose to call. Learn more about [function calling](https://platform.openai.com/docs/guides/function-calling).
    /// </summary>
    public sealed partial class FunctionTool
    {
        /// <summary>
        /// The type of the function tool. Always `function`.<br/>
        /// Default Value: function
        /// </summary>
        /// <default>global::G.FunctionToolType.Function</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.FunctionToolType Type { get; set; } = global::G.FunctionToolType.Function;

        /// <summary>
        /// The name of the function to call.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionTool" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the function tool. Always `function`.<br/>
        /// Default Value: function
        /// </param>
        /// <param name="name">
        /// The name of the function to call.
        /// </param>
        /// <param name="description"></param>
        /// <param name="parameters"></param>
        /// <param name="strict"></param>
        public FunctionTool(
            string name,
            string? description,
            object? parameters,
            bool? strict,
            global::G.FunctionToolType type = global::G.FunctionToolType.Function)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.Description = description;
            this.Parameters = parameters;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FunctionTool" /> class.
        /// </summary>
        public FunctionTool()
        {
        }
    }
}