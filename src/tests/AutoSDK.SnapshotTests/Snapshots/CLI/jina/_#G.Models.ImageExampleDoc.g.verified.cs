﻿//HintName: G.Models.ImageExampleDoc.g.cs

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// URL of an image file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// base64 representation of the Image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public byte[]? Bytes { get; set; }

        /// <summary>
        /// base64 representation of the Image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytesname")]
        public string? Bytesname { get; set; }

        /// <summary>
        /// Image representation that can hold URL of an image or a base64 representation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<string, byte[]>))]
        public global::G.AnyOf<string, byte[]>? Image { get; set; }

        /// <summary>
        /// The label of the image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<bool?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<bool?, string> Label { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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