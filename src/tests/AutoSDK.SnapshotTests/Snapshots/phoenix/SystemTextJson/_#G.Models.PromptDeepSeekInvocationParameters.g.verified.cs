//HintName: G.Models.PromptDeepSeekInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptDeepSeekInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"deepseek"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "deepseek";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deepseek")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptDeepSeekInvocationParametersContent Deepseek { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDeepSeekInvocationParameters" /> class.
        /// </summary>
        /// <param name="deepseek"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptDeepSeekInvocationParameters(
            global::G.PromptDeepSeekInvocationParametersContent deepseek,
            string type = "deepseek")
        {
            this.Type = type;
            this.Deepseek = deepseek ?? throw new global::System.ArgumentNullException(nameof(deepseek));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptDeepSeekInvocationParameters" /> class.
        /// </summary>
        public PromptDeepSeekInvocationParameters()
        {
        }
    }
}