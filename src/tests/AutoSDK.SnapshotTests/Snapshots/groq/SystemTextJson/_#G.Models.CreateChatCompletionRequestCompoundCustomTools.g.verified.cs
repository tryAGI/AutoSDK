//HintName: G.Models.CreateChatCompletionRequestCompoundCustomTools.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for tools available to Compound.
    /// </summary>
    public sealed partial class CreateChatCompletionRequestCompoundCustomTools
    {
        /// <summary>
        /// A list of tool names that are enabled for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled_tools")]
        public global::System.Collections.Generic.IList<string>? EnabledTools { get; set; }

        /// <summary>
        /// Configuration for the Wolfram tool integration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wolfram_settings")]
        public global::G.CreateChatCompletionRequestCompoundCustomToolsWolframSettings? WolframSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestCompoundCustomTools" /> class.
        /// </summary>
        /// <param name="enabledTools">
        /// A list of tool names that are enabled for the request.
        /// </param>
        /// <param name="wolframSettings">
        /// Configuration for the Wolfram tool integration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChatCompletionRequestCompoundCustomTools(
            global::System.Collections.Generic.IList<string>? enabledTools,
            global::G.CreateChatCompletionRequestCompoundCustomToolsWolframSettings? wolframSettings)
        {
            this.EnabledTools = enabledTools;
            this.WolframSettings = wolframSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChatCompletionRequestCompoundCustomTools" /> class.
        /// </summary>
        public CreateChatCompletionRequestCompoundCustomTools()
        {
        }
    }
}