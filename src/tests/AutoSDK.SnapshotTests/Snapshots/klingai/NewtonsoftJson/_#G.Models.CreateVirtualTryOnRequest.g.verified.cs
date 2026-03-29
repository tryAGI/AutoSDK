//HintName: G.Models.CreateVirtualTryOnRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVirtualTryOnRequest
    {
        /// <summary>
        /// Model to use for virtual try-on.<br/>
        /// Default Value: kolors-virtual-try-on-v1-5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name")]
        public global::G.CreateVirtualTryOnRequestModelName? ModelName { get; set; }

        /// <summary>
        /// URL of the person image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("person_image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string PersonImageUrl { get; set; } = default!;

        /// <summary>
        /// Array of garment image URLs. 1-5 items.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cloth_image_urls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ClothImageUrls { get; set; } = default!;

        /// <summary>
        /// URL to receive webhook callback when task completes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVirtualTryOnRequest" /> class.
        /// </summary>
        /// <param name="personImageUrl">
        /// URL of the person image.
        /// </param>
        /// <param name="clothImageUrls">
        /// Array of garment image URLs. 1-5 items.
        /// </param>
        /// <param name="modelName">
        /// Model to use for virtual try-on.<br/>
        /// Default Value: kolors-virtual-try-on-v1-5
        /// </param>
        /// <param name="callbackUrl">
        /// URL to receive webhook callback when task completes.
        /// </param>
        public CreateVirtualTryOnRequest(
            string personImageUrl,
            global::System.Collections.Generic.IList<string> clothImageUrls,
            global::G.CreateVirtualTryOnRequestModelName? modelName,
            string? callbackUrl)
        {
            this.ModelName = modelName;
            this.PersonImageUrl = personImageUrl ?? throw new global::System.ArgumentNullException(nameof(personImageUrl));
            this.ClothImageUrls = clothImageUrls ?? throw new global::System.ArgumentNullException(nameof(clothImageUrls));
            this.CallbackUrl = callbackUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVirtualTryOnRequest" /> class.
        /// </summary>
        public CreateVirtualTryOnRequest()
        {
        }
    }
}