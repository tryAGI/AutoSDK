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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Document identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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