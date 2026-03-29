//HintName: G.Models.FeedbackPayloadPath.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Discovered path in feedback payload with inferred type.
    /// </summary>
    public sealed partial class FeedbackPayloadPath
    {
        /// <summary>
        /// Dot path into payload (e.g. 'output.score').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JsonPath { get; set; }

        /// <summary>
        /// Inferred type of value at path.<br/>
        /// Default Value: numeric
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FeedbackPayloadPathValueTypeJsonConverter))]
        public global::G.FeedbackPayloadPathValueType? ValueType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackPayloadPath" /> class.
        /// </summary>
        /// <param name="jsonPath">
        /// Dot path into payload (e.g. 'output.score').
        /// </param>
        /// <param name="valueType">
        /// Inferred type of value at path.<br/>
        /// Default Value: numeric
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackPayloadPath(
            string jsonPath,
            global::G.FeedbackPayloadPathValueType? valueType)
        {
            this.JsonPath = jsonPath ?? throw new global::System.ArgumentNullException(nameof(jsonPath));
            this.ValueType = valueType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackPayloadPath" /> class.
        /// </summary>
        public FeedbackPayloadPath()
        {
        }
    }
}