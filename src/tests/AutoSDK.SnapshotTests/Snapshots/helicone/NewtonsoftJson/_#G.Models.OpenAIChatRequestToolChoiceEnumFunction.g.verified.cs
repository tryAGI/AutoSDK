//HintName: G.Models.OpenAIChatRequestToolChoiceEnumFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIChatRequestToolChoiceEnumFunction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.OpenAIChatRequestToolChoiceEnumFunctionType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequestToolChoiceEnumFunction" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        public OpenAIChatRequestToolChoiceEnumFunction(
            string name,
            global::G.OpenAIChatRequestToolChoiceEnumFunctionType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequestToolChoiceEnumFunction" /> class.
        /// </summary>
        public OpenAIChatRequestToolChoiceEnumFunction()
        {
        }
    }
}