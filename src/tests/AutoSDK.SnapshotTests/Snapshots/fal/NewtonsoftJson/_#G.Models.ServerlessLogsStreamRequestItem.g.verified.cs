//HintName: G.Models.ServerlessLogsStreamRequestItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Filter for log labels
    /// </summary>
    public sealed partial class ServerlessLogsStreamRequestItem
    {
        /// <summary>
        /// Label key to filter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Filter value
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> Value { get; set; } = default!;

        /// <summary>
        /// Condition type for label filtering
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ServerlessLogsStreamRequestItemConditionTypeJsonConverter))]
        public global::G.ServerlessLogsStreamRequestItemConditionType? ConditionType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessLogsStreamRequestItem" /> class.
        /// </summary>
        /// <param name="key">
        /// Label key to filter
        /// </param>
        /// <param name="value">
        /// Filter value
        /// </param>
        /// <param name="conditionType">
        /// Condition type for label filtering
        /// </param>
        public ServerlessLogsStreamRequestItem(
            string key,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> value,
            global::G.ServerlessLogsStreamRequestItemConditionType? conditionType)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Value = value;
            this.ConditionType = conditionType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessLogsStreamRequestItem" /> class.
        /// </summary>
        public ServerlessLogsStreamRequestItem()
        {
        }
    }
}