//HintName: G.Models.SearchFilterCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a condition with a field, operator, and value.
    /// </summary>
    public sealed partial class SearchFilterCondition
    {
        /// <summary>
        /// The field to apply the condition on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The value to compare against
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// The operator for the condition
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConditionOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConditionOperator Operator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFilterCondition" /> class.
        /// </summary>
        /// <param name="key">
        /// The field to apply the condition on
        /// </param>
        /// <param name="value">
        /// The value to compare against
        /// </param>
        /// <param name="operator">
        /// The operator for the condition
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchFilterCondition(
            string key,
            object value,
            global::G.ConditionOperator @operator)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Operator = @operator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFilterCondition" /> class.
        /// </summary>
        public SearchFilterCondition()
        {
        }
    }
}