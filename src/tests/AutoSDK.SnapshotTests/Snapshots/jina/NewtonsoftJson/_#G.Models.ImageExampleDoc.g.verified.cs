//HintName: G.Models.ImageExampleDoc.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// ImageDoc with fields and a label
    /// </summary>
    public sealed partial class ImageExampleDoc
    {
        /// <summary>
        /// The ID of the BaseDoc. This is useful for indexing in vector stores. If not set by user, it will automatically be assigned a random value<br/>
        /// Example: e10b550cf99e2e072e22420af5c6eb47
        /// </summary>
        /// <example>e10b550cf99e2e072e22420af5c6eb47</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// URL of an image file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// base64 representation of the Image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes")]
        public byte[]? Bytes { get; set; }

        /// <summary>
        /// base64 representation of the Image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytesname")]
        public string? Bytesname { get; set; }

        /// <summary>
        /// Image representation that can hold URL of an image or a base64 representation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public global::G.AnyOf<string, byte[]>? Image { get; set; }

        /// <summary>
        /// The label of the image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("label", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<bool?, string> Label { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageExampleDoc" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the BaseDoc. This is useful for indexing in vector stores. If not set by user, it will automatically be assigned a random value<br/>
        /// Example: e10b550cf99e2e072e22420af5c6eb47
        /// </param>
        /// <param name="url">
        /// URL of an image file
        /// </param>
        /// <param name="bytes">
        /// base64 representation of the Image.
        /// </param>
        /// <param name="bytesname">
        /// base64 representation of the Image.
        /// </param>
        /// <param name="image">
        /// Image representation that can hold URL of an image or a base64 representation
        /// </param>
        /// <param name="label">
        /// The label of the image
        /// </param>
        public ImageExampleDoc(
            global::G.AnyOf<bool?, string> label,
            string? id,
            string? url,
            byte[]? bytes,
            string? bytesname,
            global::G.AnyOf<string, byte[]>? image)
        {
            this.Label = label;
            this.Id = id;
            this.Url = url;
            this.Bytes = bytes;
            this.Bytesname = bytesname;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageExampleDoc" /> class.
        /// </summary>
        public ImageExampleDoc()
        {
        }
    }
}