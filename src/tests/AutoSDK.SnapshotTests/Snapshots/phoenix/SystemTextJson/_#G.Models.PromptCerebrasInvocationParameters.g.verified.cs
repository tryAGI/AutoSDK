//HintName: G.Models.PromptCerebrasInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptCerebrasInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"cerebras"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "cerebras";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cerebras")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptCerebrasInvocationParametersContent Cerebras { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCerebrasInvocationParameters" /> class.
        /// </summary>
        /// <param name="cerebras"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptCerebrasInvocationParameters(
            global::G.PromptCerebrasInvocationParametersContent cerebras,
            string type = "cerebras")
        {
            this.Type = type;
            this.Cerebras = cerebras ?? throw new global::System.ArgumentNullException(nameof(cerebras));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCerebrasInvocationParameters" /> class.
        /// </summary>
        public PromptCerebrasInvocationParameters()
        {
        }
    }
}