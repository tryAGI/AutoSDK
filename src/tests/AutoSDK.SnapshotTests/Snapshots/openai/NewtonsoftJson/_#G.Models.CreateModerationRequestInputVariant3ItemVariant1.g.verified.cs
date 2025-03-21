//HintName: G.Models.CreateModerationRequestInputVariant3ItemVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object describing an image to classify.
    /// </summary>
    public sealed partial class CreateModerationRequestInputVariant3ItemVariant1
    {
        /// <summary>
        /// Always `image_url`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateModerationRequestInputVariant3ItemVariant1Type Type { get; set; }

        /// <summary>
        /// Contains either an image URL or a data URL for a base64 encoded image.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateModerationRequestInputVariant3ItemVariant1ImageUrl ImageUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequestInputVariant3ItemVariant1" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `image_url`.
        /// </param>
        /// <param name="imageUrl">
        /// Contains either an image URL or a data URL for a base64 encoded image.
        /// </param>
        public CreateModerationRequestInputVariant3ItemVariant1(
            global::G.CreateModerationRequestInputVariant3ItemVariant1ImageUrl imageUrl,
            global::G.CreateModerationRequestInputVariant3ItemVariant1Type type)
        {
            this.ImageUrl = imageUrl ?? throw new global::System.ArgumentNullException(nameof(imageUrl));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModerationRequestInputVariant3ItemVariant1" /> class.
        /// </summary>
        public CreateModerationRequestInputVariant3ItemVariant1()
        {
        }
    }
}