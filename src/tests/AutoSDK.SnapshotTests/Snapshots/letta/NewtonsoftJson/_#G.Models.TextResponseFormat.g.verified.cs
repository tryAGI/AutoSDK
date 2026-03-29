//HintName: G.Models.TextResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response format for plain text responses.
    /// </summary>
    public sealed partial class TextResponseFormat
    {
        /// <summary>
        /// The type of the response format.<br/>
        /// Default Value: text
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the response format.<br/>
        /// Default Value: text
        /// </param>
        public TextResponseFormat(
            string? type)
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