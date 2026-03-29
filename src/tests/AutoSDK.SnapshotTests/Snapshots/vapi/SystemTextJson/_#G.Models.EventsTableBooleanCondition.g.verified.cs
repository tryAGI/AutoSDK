//HintName: G.Models.EventsTableBooleanCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EventsTableBooleanCondition
    {
        /// <summary>
        /// The boolean field name from the event data<br/>
        /// Example: success
        /// </summary>
        /// <example>success</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Column { get; set; }

        /// <summary>
        /// Boolean comparison operator<br/>
        /// Example: =
        /// </summary>
        /// <example>=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EventsTableBooleanConditionOperatorJsonConverter))]
        public global::G.EventsTableBooleanConditionOperator Operator { get; set; }

        /// <summary>
        /// The boolean value to compare<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsTableBooleanCondition" /> class.
        /// </summary>
        /// <param name="column">
        /// The boolean field name from the event data<br/>
        /// Example: success
        /// </param>
        /// <param name="value">
        /// The boolean value to compare<br/>
        /// Example: true
        /// </param>
        /// <param name="operator">
        /// Boolean comparison operator<br/>
        /// Example: =
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EventsTableBooleanCondition(
            string column,
            bool value,
            global::G.EventsTableBooleanConditionOperator @operator)
        {
            this.Column = column ?? throw new global::System.ArgumentNullException(nameof(column));
            this.Operator = @operator;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsTableBooleanCondition" /> class.
        /// </summary>
        public EventsTableBooleanCondition()
        {
        }
    }
}