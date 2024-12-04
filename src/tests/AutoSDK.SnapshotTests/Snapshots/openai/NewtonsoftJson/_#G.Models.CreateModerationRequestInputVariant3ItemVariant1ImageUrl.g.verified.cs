//HintName: G.Models.CreateModerationRequestInputVariant3ItemVariant1ImageUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Contains either an image URL or a data URL for a base64 encoded image.
    /// </summary>
    public sealed partial class CreateModerationRequestInputVariant3ItemVariant1ImageUrl
    {
        /// <summary>
        /// Either a URL of the image or the base64 encoded image data.<br/>
        /// Example: https://example.com/image.jpg
        /// </summary>
        /// <example>https://example.com/image.jpg</example>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequestInputVariant3ItemVariant1ImageUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// Either a URL of the image or the base64 encoded image data.<br/>
        /// Example: https://example.com/image.jpg
        /// </param>
        public CreateModerationRequestInputVariant3ItemVariant1ImageUrl(
            string url)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequestInputVariant3ItemVariant1ImageUrl" /> class.
        /// </summary>
        public CreateModerationRequestInputVariant3ItemVariant1ImageUrl()
        {
        }
    }
}