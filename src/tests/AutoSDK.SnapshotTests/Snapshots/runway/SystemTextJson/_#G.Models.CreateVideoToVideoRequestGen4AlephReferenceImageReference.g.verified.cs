//HintName: G.Models.CreateVideoToVideoRequestGen4AlephReferenceImageReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Passing an image reference allows the model to emulate the style or content of the reference in the output.
    /// </summary>
    public sealed partial class CreateVideoToVideoRequestGen4AlephReferenceImageReference
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"image"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "image";

        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </summary>
        /// <example>https://example.com/image.jpg</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestGen4AlephReferenceImageReference" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVideoToVideoRequestGen4AlephReferenceImageReference(
            string uri,
            string type = "image")
        {
            this.Uri = uri;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVideoToVideoRequestGen4AlephReferenceImageReference" /> class.
        /// </summary>
        public CreateVideoToVideoRequestGen4AlephReferenceImageReference()
        {
        }
    }
}