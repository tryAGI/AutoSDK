//HintName: G.Models.ToolMockInputMatchRuleVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolMockInputMatchRuleVariant1
    {
        /// <summary>
        /// Match any input of the tool
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ToolMockInputMatchRuleVariant1Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMockInputMatchRuleVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// Match any input of the tool
        /// </param>
        public ToolMockInputMatchRuleVariant1(
            global::G.ToolMockInputMatchRuleVariant1Type type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolMockInputMatchRuleVariant1" /> class.
        /// </summary>
        public ToolMockInputMatchRuleVariant1()
        {
        }
    }
}