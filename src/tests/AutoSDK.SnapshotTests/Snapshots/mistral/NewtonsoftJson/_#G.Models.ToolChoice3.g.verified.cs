//HintName: G.Models.ToolChoice3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ToolChoice is either a ToolChoiceEnum or a ToolChoice
    /// </summary>
    public sealed partial class ToolChoice3
    {
        /// <summary>
        /// this restriction of `Function` is used to select a specific function to call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FunctionName Function { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ToolTypes? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoice3" /> class.
        /// </summary>
        /// <param name="function">
        /// this restriction of `Function` is used to select a specific function to call
        /// </param>
        /// <param name="type"></param>
        public ToolChoice3(
            global::G.FunctionName function,
            global::G.ToolTypes? type)
        {
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolChoice3" /> class.
        /// </summary>
        public ToolChoice3()
        {
        }
    }
}