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
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateVirtualTryOnRequestModelNameJsonConverter))]
        public global::G.CreateVirtualTryOnRequestModelName? ModelName { get; set; }

        /// <summary>
        /// URL of the person image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("person_image_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PersonImageUrl { get; set; }

        /// <summary>
        /// Array of garment image URLs. 1-5 items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloth_image_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ClothImageUrls { get; set; }

        /// <summary>
        /// URL to receive webhook callback when task completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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