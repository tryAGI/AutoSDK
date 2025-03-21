//HintName: G.Models.MessageContentTextObjectText.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageContentTextObjectText
    {
        /// <summary>
        /// The data that makes up the text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public string Value { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageContentTextAnnotationsFileCitationObject, global::G.MessageContentTextAnnotationsFilePathObject>> Annotations { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextObjectText" /> class.
        /// </summary>
        /// <param name="value">
        /// The data that makes up the text.
        /// </param>
        /// <param name="annotations"></param>
        public MessageContentTextObjectText(
            string value,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.MessageContentTextAnnotationsFileCitationObject, global::G.MessageContentTextAnnotationsFilePathObject>> annotations)
        {
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Annotations = annotations ?? throw new global::System.ArgumentNullException(nameof(annotations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentTextObjectText" /> class.
        /// </summary>
        public MessageContentTextObjectText()
        {
        }
    }
}