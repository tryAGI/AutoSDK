//HintName: G.Models.GroupCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupCondition
    {
        /// <summary>
        /// This is the type discriminator for group condition<br/>
        /// Example: group
        /// </summary>
        /// <example>group</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GroupConditionTypeJsonConverter))]
        public global::G.GroupConditionType Type { get; set; }

        /// <summary>
        /// This is the logical operator for combining conditions in this group
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.GroupConditionOperatorJsonConverter))]
        public global::G.GroupConditionOperator Operator { get; set; } = default!;

        /// <summary>
        /// This is the list of nested conditions to evaluate.<br/>
        /// Supports recursive nesting of groups for complex logic.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conditions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.RegexCondition, global::G.LiquidCondition, global::G.GroupCondition>> Conditions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupCondition" /> class.
        /// </summary>
        /// <param name="operator">
        /// This is the logical operator for combining conditions in this group
        /// </param>
        /// <param name="conditions">
        /// This is the list of nested conditions to evaluate.<br/>
        /// Supports recursive nesting of groups for complex logic.
        /// </param>
        /// <param name="type">
        /// This is the type discriminator for group condition<br/>
        /// Example: group
        /// </param>
        public GroupCondition(
            global::G.GroupConditionOperator @operator,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.RegexCondition, global::G.LiquidCondition, global::G.GroupCondition>> conditions,
            global::G.GroupConditionType type)
        {
            this.Type = type;
            this.Operator = @operator;
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupCondition" /> class.
        /// </summary>
        public GroupCondition()
        {
        }
    }
}