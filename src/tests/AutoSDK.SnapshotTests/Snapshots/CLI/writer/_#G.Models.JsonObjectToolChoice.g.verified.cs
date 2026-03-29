//HintName: G.Models.JsonObjectToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonObjectToolChoice
    {
        /// <summary>
        /// A JSON object that specifies the tool to call. For example, `{"type": "function", "function": {"name": "get_current_weather"}}`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonObjectToolChoice" /> class.
        /// </summary>
        /// <param name="value">
        /// A JSON object that specifies the tool to call. For example, `{"type": "function", "function": {"name": "get_current_weather"}}`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JsonObjectToolChoice(
            object value)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonObjectToolChoice" /> class.
        /// </summary>
        public JsonObjectToolChoice()
        {
        }
    }
}