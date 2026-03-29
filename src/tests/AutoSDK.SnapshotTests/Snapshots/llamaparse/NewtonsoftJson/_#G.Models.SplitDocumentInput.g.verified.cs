//HintName: G.Models.SplitDocumentInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Document input specification.
    /// </summary>
    public sealed partial class SplitDocumentInput
    {
        /// <summary>
        /// Type of document input. Valid values are: file_id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Document identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitDocumentInput" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of document input. Valid values are: file_id
        /// </param>
        /// <param name="value">
        /// Document identifier.
        /// </param>
        public SplitDocumentInput(
            string type,
            string value)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitDocumentInput" /> class.
        /// </summary>
        public SplitDocumentInput()
        {
        }
    }
}