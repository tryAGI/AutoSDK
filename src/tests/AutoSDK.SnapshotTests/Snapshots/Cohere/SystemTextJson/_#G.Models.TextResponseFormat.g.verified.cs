//HintName: G.Models.TextResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextResponseFormat
    {
        /// <summary>
        /// Defaults to `"text"`.<br/>
        /// When set to `"json_object"`, the model's output will be a valid JSON Object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseFormatTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ResponseFormatType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// Defaults to `"text"`.<br/>
        /// When set to `"json_object"`, the model's output will be a valid JSON Object.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TextResponseFormat(
            global::G.ResponseFormatType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResponseFormat" /> class.
        /// </summary>
        public TextResponseFormat()
        {
        }
    }
}