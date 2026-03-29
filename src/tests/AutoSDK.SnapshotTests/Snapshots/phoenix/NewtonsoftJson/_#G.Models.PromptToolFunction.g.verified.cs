//HintName: G.Models.PromptToolFunction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptToolFunction
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"function"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "function";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PromptToolFunctionDefinition Function { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptToolFunction" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type"></param>
        public PromptToolFunction(
            global::G.PromptToolFunctionDefinition function,
            string type = "function")
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptToolFunction" /> class.
        /// </summary>
        public PromptToolFunction()
        {
        }
    }
}