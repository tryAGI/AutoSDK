//HintName: G.Models.CreateCharacterPerformanceRequestActTwoCharacterCharacterImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An image of your character. In the output, the character will use the reference video performance in its original static environment.
    /// </summary>
    public sealed partial class CreateCharacterPerformanceRequestActTwoCharacterCharacterImage
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
        /// Initializes a new instance of the <see cref="CreateCharacterPerformanceRequestActTwoCharacterCharacterImage" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCharacterPerformanceRequestActTwoCharacterCharacterImage(
            string uri,
            string type = "image")
        {
            this.Type = type;
            this.Uri = uri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCharacterPerformanceRequestActTwoCharacterCharacterImage" /> class.
        /// </summary>
        public CreateCharacterPerformanceRequestActTwoCharacterCharacterImage()
        {
        }
    }
}