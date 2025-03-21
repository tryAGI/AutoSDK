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
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_file", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MessageContentImageFileObjectImageFile ImageFile { get; set; } = default!;

        /// <summary>
        /// Always `image_file`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.MessageContentImageFileObjectType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentImageFileObject" /> class.
        /// </summary>
        /// <param name="imageFile"></param>
        /// <param name="type">
        /// Always `image_file`.
        /// </param>
        public MessageContentImageFileObject(
            global::G.MessageContentImageFileObjectImageFile imageFile,
            global::G.MessageContentImageFileObjectType type)
        {
            this.ImageFile = imageFile ?? throw new global::System.ArgumentNullException(nameof(imageFile));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageContentImageFileObject" /> class.
        /// </summary>
        public MessageContentImageFileObject()
        {
        }
    }
}