//HintName: G.Models.MessageContentTextAnnotationsFileCitationObjectFileCitation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageContentTextAnnotationsFileCitationObjectFileCitation
    {
        /// <summary>
        /// The ID of the specific File the citation is from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// The specific quote in the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quote")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Quote { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}