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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "specific_function";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FunctionName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptToolChoiceSpecificFunctionTool" /> class.
        /// </summary>
        /// <param name="functionName"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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