//HintName: G.Models.FunctionTool.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

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
        public global::G.AnyOf<string, object>? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<object, object> Parameters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("strict", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<bool?, object> Strict { get; set; } = default!;

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
            global::G.AnyOf<object, object> parameters,
            global::G.AnyOf<bool?, object> strict,
            global::G.AnyOf<string, object>? description,
            global::G.FunctionToolType type = global::G.FunctionToolType.Function)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Parameters = parameters;
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