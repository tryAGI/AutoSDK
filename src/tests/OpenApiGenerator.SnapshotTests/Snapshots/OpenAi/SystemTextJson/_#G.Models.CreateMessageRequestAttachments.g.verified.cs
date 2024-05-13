//HintName: G.Models.CreateMessageRequestAttachments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateMessageRequestAttachments
    {
        /// <summary>
        /// The ID of the file to attach to the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The tools to add this file to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<object?>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}