//HintName: G.Models.OpenAIChatRequestTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIChatRequestTool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAIChatRequestToolFunction Function { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.OpenAIChatRequestToolType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequestTool" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type"></param>
        public OpenAIChatRequestTool(
            global::G.OpenAIChatRequestToolFunction function,
            global::G.OpenAIChatRequestToolType type)
        {
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIChatRequestTool" /> class.
        /// </summary>
        public OpenAIChatRequestTool()
        {
        }
    }
}