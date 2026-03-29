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
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Column { get; set; }

        /// <summary>
        /// Number comparison operator<br/>
        /// Example: &gt;=
        /// </summary>
        /// <example>&gt;=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EventsTableNumberConditionOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EventsTableNumberConditionOperator Operator { get; set; }

        /// <summary>
        /// The number value to compare<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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