//HintName: G.Models.EventsTableNumberCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EventsTableNumberCondition
    {
        /// <summary>
        /// The number field name from the event data<br/>
        /// Example: latency
        /// </summary>
        /// <example>latency</example>
        [global::Newtonsoft.Json.JsonProperty("column", Required = global::Newtonsoft.Json.Required.Always)]
        public string Column { get; set; } = default!;

        /// <summary>
        /// Number comparison operator<br/>
        /// Example: &gt;=
        /// </summary>
        /// <example>&gt;=</example>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EventsTableNumberConditionOperator Operator { get; set; } = default!;

        /// <summary>
        /// The number value to compare<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsTableNumberCondition" /> class.
        /// </summary>
        /// <param name="column">
        /// The number field name from the event data<br/>
        /// Example: latency
        /// </param>
        /// <param name="operator">
        /// Number comparison operator<br/>
        /// Example: &gt;=
        /// </param>
        /// <param name="value">
        /// The number value to compare<br/>
        /// Example: 1000
        /// </param>
        public EventsTableNumberCondition(
            string column,
            global::G.EventsTableNumberConditionOperator @operator,
            double value)
        {
            this.Column = column ?? throw new global::System.ArgumentNullException(nameof(column));
            this.Operator = @operator;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsTableNumberCondition" /> class.
        /// </summary>
        public EventsTableNumberCondition()
        {
        }
    }
}