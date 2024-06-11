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
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("annotations")]
        public global::System.Collections.Generic.IList<global::System.OneOf<global::G.MessageDeltaContentTextAnnotationsFileCitationObject?, global::G.MessageDeltaContentTextAnnotationsFilePathObject?>>? Annotations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}