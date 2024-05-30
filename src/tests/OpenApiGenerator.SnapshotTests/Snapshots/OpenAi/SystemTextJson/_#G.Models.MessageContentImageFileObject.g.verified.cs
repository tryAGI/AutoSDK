//HintName: G.Models.MessageContentImageFileObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// References an image [File](/docs/api-reference/files) in the content of a message.
    /// </summary>
    public sealed partial class MessageContentImageFileObject
    {
        /// <summary>
        /// Always `image_file`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.MessageContentImageFileObjectTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required MessageContentImageFileObjectType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required MessageContentImageFileObjectImageFile ImageFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}