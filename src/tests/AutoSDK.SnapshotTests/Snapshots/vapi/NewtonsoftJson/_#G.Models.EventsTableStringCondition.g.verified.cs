//HintName: G.Models.EventsTableStringCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EventsTableStringCondition
    {
        /// <summary>
        /// The string field name from the event data<br/>
        /// Example: provider
        /// </summary>
        /// <example>provider</example>
        [global::Newtonsoft.Json.JsonProperty("column", Required = global::Newtonsoft.Json.Required.Always)]
        public string Column { get; set; } = default!;

        /// <summary>
        /// String comparison operator<br/>
        /// Example: =
        /// </summary>
        /// <example>=</example>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EventsTableStringConditionOperator Operator { get; set; } = default!;

        /// <summary>
        /// The string value to compare<br/>
        /// Example: openai
        /// </summary>
        /// <example>openai</example>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsTableStringCondition" /> class.
        /// </summary>
        /// <param name="column">
        /// The string field name from the event data<br/>
        /// Example: provider
        /// </param>
        /// <param name="operator">
        /// String comparison operator<br/>
        /// Example: =
        /// </param>
        /// <param name="value">
        /// The string value to compare<br/>
        /// Example: openai
        /// </param>
        public EventsTableStringCondition(
            string column,
            global::G.EventsTableStringConditionOperator @operator,
            string value)
        {
            this.Column = column ?? throw new global::System.ArgumentNullException(nameof(column));
            this.Operator = @operator;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsTableStringCondition" /> class.
        /// </summary>
        public EventsTableStringCondition()
        {
        }
    }
}