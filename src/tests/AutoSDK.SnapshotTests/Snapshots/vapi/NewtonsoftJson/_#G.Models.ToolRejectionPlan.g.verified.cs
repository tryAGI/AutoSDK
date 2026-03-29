//HintName: G.Models.ToolRejectionPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolRejectionPlan
    {
        /// <summary>
        /// This is the list of conditions that must be evaluated.<br/>
        /// Usage:<br/>
        /// - If all conditions match (AND logic), the tool call is rejected.<br/>
        /// - For OR logic at the top level, use a single 'group' condition with operator: 'OR'.<br/>
        /// @default [] - Empty array means tool always executes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conditions")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.RegexCondition, global::G.LiquidCondition, global::G.GroupCondition>>? Conditions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRejectionPlan" /> class.
        /// </summary>
        /// <param name="conditions">
        /// This is the list of conditions that must be evaluated.<br/>
        /// Usage:<br/>
        /// - If all conditions match (AND logic), the tool call is rejected.<br/>
        /// - For OR logic at the top level, use a single 'group' condition with operator: 'OR'.<br/>
        /// @default [] - Empty array means tool always executes
        /// </param>
        public ToolRejectionPlan(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.RegexCondition, global::G.LiquidCondition, global::G.GroupCondition>>? conditions)
        {
            this.Conditions = conditions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolRejectionPlan" /> class.
        /// </summary>
        public ToolRejectionPlan()
        {
        }
    }
}