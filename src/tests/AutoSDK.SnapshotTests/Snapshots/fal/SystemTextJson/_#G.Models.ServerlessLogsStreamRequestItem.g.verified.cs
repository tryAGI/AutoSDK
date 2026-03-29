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
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Filter value
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> Value { get; set; }

        /// <summary>
        /// Condition type for label filtering
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ServerlessLogsStreamRequestItemConditionTypeJsonConverter))]
        public global::G.ServerlessLogsStreamRequestItemConditionType? ConditionType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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