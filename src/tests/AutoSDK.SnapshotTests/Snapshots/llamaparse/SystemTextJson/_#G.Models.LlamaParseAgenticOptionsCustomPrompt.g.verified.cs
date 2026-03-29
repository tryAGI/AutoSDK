//HintName: G.Models.LlamaParseAgenticOptionsCustomPrompt.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Custom instructions for the AI parser. Use to guide extraction behavior, specify output formatting, or provide domain-specific context. Example: 'Extract financial tables with currency symbols. Format dates as YYYY-MM-DD.'
    /// </summary>
    public sealed partial class LlamaParseAgenticOptionsCustomPrompt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}