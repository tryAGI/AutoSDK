//HintName: G.Models.PromptOpenAIInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptOpenAIInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"openai"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "openai";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("openai")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptOpenAIInvocationParametersContent Openai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOpenAIInvocationParameters" /> class.
        /// </summary>
        /// <param name="openai"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptOpenAIInvocationParameters(
            global::G.PromptOpenAIInvocationParametersContent openai,
            string type = "openai")
        {
            this.Type = type;
            this.Openai = openai ?? throw new global::System.ArgumentNullException(nameof(openai));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptOpenAIInvocationParameters" /> class.
        /// </summary>
        public PromptOpenAIInvocationParameters()
        {
        }
    }
}