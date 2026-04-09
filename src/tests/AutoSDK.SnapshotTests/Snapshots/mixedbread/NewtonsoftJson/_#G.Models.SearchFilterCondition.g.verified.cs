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
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// The value to compare against
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public object Value { get; set; } = default!;

        /// <summary>
        /// The operator for the condition
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ConditionOperatorJsonConverter))]
        public global::G.ConditionOperator Operator { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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