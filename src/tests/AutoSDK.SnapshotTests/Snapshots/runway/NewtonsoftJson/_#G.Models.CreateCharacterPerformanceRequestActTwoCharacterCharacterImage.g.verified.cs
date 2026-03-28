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
        /// Initializes a new instance of the <see cref="CreateCharacterPerformanceRequestActTwoCharacterCharacterImage" /> class.
        /// </summary>
        /// <param name="uri">
        /// A HTTPS URL, Runway or data URI containing an encoded image. See [our docs](/assets/inputs#images) on image inputs for more information.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        /// <param name="type"></param>
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