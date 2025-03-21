//HintName: G.Models.MessageDeltaContentTextObjectText.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageDeltaContentTextObjectText
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageDeltaContentTextAnnotationsFileCitationObject, global::G.MessageDeltaContentTextAnnotationsFilePathObject>>? Annotations { get; set; }

        /// <summary>
        /// The data that makes up the text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextObjectText" /> class.
        /// </summary>
        /// <param name="annotations"></param>
        /// <param name="value">
        /// The data that makes up the text.
        /// </param>
        public MessageDeltaContentTextObjectText(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageDeltaContentTextAnnotationsFileCitationObject, global::G.MessageDeltaContentTextAnnotationsFilePathObject>>? annotations,
            string? value)
        {
            this.Annotations = annotations;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextObjectText" /> class.
        /// </summary>
        public MessageDeltaContentTextObjectText()
        {
        }
    }
}