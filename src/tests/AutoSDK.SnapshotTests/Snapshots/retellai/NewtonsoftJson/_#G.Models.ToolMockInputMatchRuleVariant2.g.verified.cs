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
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ToolMockInputMatchRuleVariant2TypeJsonConverter))]
        public global::G.ToolMockInputMatchRuleVariant2Type Type { get; set; }

        /// <summary>
        /// Arguments to match. Only provided fields will be checked
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("args", Required = global::Newtonsoft.Json.Required.Always)]
        public object Args { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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