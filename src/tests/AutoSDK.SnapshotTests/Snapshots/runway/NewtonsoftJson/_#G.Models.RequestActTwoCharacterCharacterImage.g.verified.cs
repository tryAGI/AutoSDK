//HintName: G.Models.RequestActTwoCharacterCharacterImage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An image of your character. In the output, the character will use the reference video performance in its original static environment.
    /// </summary>
    public sealed partial class RequestActTwoCharacterCharacterImage
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"image"</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string Type { get; set; } = "image";

        /// <summary>
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </summary>
        /// <example>https://example.com/image.jpg</example>
        [global::Newtonsoft.Json.JsonProperty("uri", Required = global::Newtonsoft.Json.Required.Always)]
        public string Uri { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestActTwoCharacterCharacterImage" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        public RequestActTwoCharacterCharacterImage(
            string uri,
            string type = "image")
        {
            this.Uri = uri;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestActTwoCharacterCharacterImage" /> class.
        /// </summary>
        public RequestActTwoCharacterCharacterImage()
        {
        }
    }
}