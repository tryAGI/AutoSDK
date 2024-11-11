//HintName: G.Models.MessageDeltaContentTextObjectText.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageDeltaContentTextObjectText
    {
        /// <summary>
        /// The data that makes up the text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotations")]
        public global::System.Collections.Generic.IList<global::G.AnnotationsItem2>? Annotations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextObjectText" /> class.
        /// </summary>
        /// <param name="value">
        /// The data that makes up the text.
        /// </param>
        /// <param name="annotations"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageDeltaContentTextObjectText(
            string? value,
            global::System.Collections.Generic.IList<global::G.AnnotationsItem2>? annotations)
        {
            this.Value = value;
            this.Annotations = annotations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextObjectText" /> class.
        /// </summary>
        public MessageDeltaContentTextObjectText()
        {
        }
    }
}