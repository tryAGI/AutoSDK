//HintName: G.Models.PromptFireworksInvocationParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptFireworksInvocationParameters
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"fireworks"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "fireworks";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fireworks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PromptFireworksInvocationParametersContent Fireworks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptFireworksInvocationParameters" /> class.
        /// </summary>
        /// <param name="fireworks"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromptFireworksInvocationParameters(
            global::G.PromptFireworksInvocationParametersContent fireworks,
            string type = "fireworks")
        {
            this.Type = type;
            this.Fireworks = fireworks ?? throw new global::System.ArgumentNullException(nameof(fireworks));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptFireworksInvocationParameters" /> class.
        /// </summary>
        public PromptFireworksInvocationParameters()
        {
        }
    }
}