//HintName: G.Models.PromptXAIInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptXAIInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"xai"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "xai";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("xai")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptXAIInvocationParametersContent Xai { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptXAIInvocationParameters" /> class.
        /// </summary>
        /// <param name="xai"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptXAIInvocationParameters(
            global::G.PromptXAIInvocationParametersContent xai,
            string type = "xai")
        {
            this.Type = type;
            this.Xai = xai ?? throw new global::System.ArgumentNullException(nameof(xai));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptXAIInvocationParameters" /> class.
        /// </summary>
        public PromptXAIInvocationParameters()
        {
        }
    }
}