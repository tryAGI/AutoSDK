//HintName: G.Models.AssistantToolsFileSearchTypeOnly.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssistantToolsFileSearchTypeOnly
    {
        /// <summary>
        /// The type of tool being defined: `file_search`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AssistantToolsFileSearchTypeOnlyTypeJsonConverter))]
        public global::G.AssistantToolsFileSearchTypeOnlyType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFileSearchTypeOnly" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool being defined: `file_search`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssistantToolsFileSearchTypeOnly(
            global::G.AssistantToolsFileSearchTypeOnlyType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssistantToolsFileSearchTypeOnly" /> class.
        /// </summary>
        public AssistantToolsFileSearchTypeOnly()
        {
        }
    }
}