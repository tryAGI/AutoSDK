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
        [global::Newtonsoft.Json.JsonProperty("json_path", Required = global::Newtonsoft.Json.Required.Always)]
        public string JsonPath { get; set; } = default!;

        /// <summary>
        /// Inferred type of value at path.<br/>
        /// Default Value: numeric
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value_type")]
        public global::G.FeedbackPayloadPathValueType? ValueType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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