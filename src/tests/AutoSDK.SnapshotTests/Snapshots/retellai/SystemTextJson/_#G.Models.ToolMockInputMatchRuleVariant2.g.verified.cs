//HintName: G.Models.ToolMockInputMatchRuleVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolMockInputMatchRuleVariant2
    {
        /// <summary>
        /// Match only calls with specific arguments
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ToolMockInputMatchRuleVariant2TypeJsonConverter))]
        public global::G.ToolMockInputMatchRuleVariant2Type Type { get; set; }

        /// <summary>
        /// Arguments to match. Only provided fields will be checked
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("args")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Args { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMockInputMatchRuleVariant2" /> class.
        /// </summary>
        /// <param name="args">
        /// Arguments to match. Only provided fields will be checked
        /// </param>
        /// <param name="type">
        /// Match only calls with specific arguments
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolMockInputMatchRuleVariant2(
            object args,
            global::G.ToolMockInputMatchRuleVariant2Type type)
        {
            this.Type = type;
            this.Args = args ?? throw new global::System.ArgumentNullException(nameof(args));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMockInputMatchRuleVariant2" /> class.
        /// </summary>
        public ToolMockInputMatchRuleVariant2()
        {
        }
    }
}