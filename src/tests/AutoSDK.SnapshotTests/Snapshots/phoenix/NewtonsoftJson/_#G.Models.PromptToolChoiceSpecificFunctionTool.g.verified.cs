//HintName: G.Models.PromptToolChoiceSpecificFunctionTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptToolChoiceSpecificFunctionTool
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"specific_function"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "specific_function";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("function_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string FunctionName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptToolChoiceSpecificFunctionTool" /> class.
        /// </summary>
        /// <param name="functionName"></param>
        /// <param name="type"></param>
        public PromptToolChoiceSpecificFunctionTool(
            string functionName,
            string type = "specific_function")
        {
            this.Type = type;
            this.FunctionName = functionName ?? throw new global::System.ArgumentNullException(nameof(functionName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptToolChoiceSpecificFunctionTool" /> class.
        /// </summary>
        public PromptToolChoiceSpecificFunctionTool()
        {
        }
    }
}