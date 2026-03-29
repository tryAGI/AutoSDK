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
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Column { get; set; }

        /// <summary>
        /// String comparison operator<br/>
        /// Example: =
        /// </summary>
        /// <example>=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EventsTableStringConditionOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EventsTableStringConditionOperator Operator { get; set; }

        /// <summary>
        /// The string value to compare<br/>
        /// Example: openai
        /// </summary>
        /// <example>openai</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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