//HintName: G.Models.PromptTogetherInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptTogetherInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"together"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "together";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("together")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptTogetherInvocationParametersContent Together { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTogetherInvocationParameters" /> class.
        /// </summary>
        /// <param name="together"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptTogetherInvocationParameters(
            global::G.PromptTogetherInvocationParametersContent together,
            string type = "together")
        {
            this.Type = type;
            this.Together = together ?? throw new global::System.ArgumentNullException(nameof(together));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptTogetherInvocationParameters" /> class.
        /// </summary>
        public PromptTogetherInvocationParameters()
        {
        }
    }
}