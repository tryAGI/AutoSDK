//HintName: G.Models.LlmTool.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LlmTool
    {
        /// <summary>
        /// The type of tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LlmToolTypeJsonConverter))]
        public global::G.LlmToolType Type { get; set; }

        /// <summary>
        /// A tool that uses another Writer model to generate a response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LlmFunction Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmTool" /> class.
        /// </summary>
        /// <param name="function">
        /// A tool that uses another Writer model to generate a response.
        /// </param>
        /// <param name="type">
        /// The type of tool.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlmTool(
            global::G.LlmFunction function,
            global::G.LlmToolType type)
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlmTool" /> class.
        /// </summary>
        public LlmTool()
        {
        }
    }
}