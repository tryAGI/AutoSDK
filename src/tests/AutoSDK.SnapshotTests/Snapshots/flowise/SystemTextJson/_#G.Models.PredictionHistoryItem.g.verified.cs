//HintName: G.Models.PredictionHistoryItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PredictionHistoryItem
    {
        /// <summary>
        /// The role of the message<br/>
        /// Example: apiMessage
        /// </summary>
        /// <example>apiMessage</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PredictionHistoryItemRoleJsonConverter))]
        public global::G.PredictionHistoryItemRole? Role { get; set; }

        /// <summary>
        /// The content of the message<br/>
        /// Example: Hello, how can I help you?
        /// </summary>
        /// <example>Hello, how can I help you?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionHistoryItem" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message<br/>
        /// Example: apiMessage
        /// </param>
        /// <param name="content">
        /// The content of the message<br/>
        /// Example: Hello, how can I help you?
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PredictionHistoryItem(
            global::G.PredictionHistoryItemRole? role,
            string? content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PredictionHistoryItem" /> class.
        /// </summary>
        public PredictionHistoryItem()
        {
        }
    }
}