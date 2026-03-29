//HintName: G.Models.EffectsInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EffectsInput
    {
        /// <summary>
        /// Array of image URLs for the effect.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_urls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ImageUrls { get; set; } = default!;

        /// <summary>
        /// Effect scene type to apply.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effect_scene", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EffectsInputEffectScene EffectScene { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectsInput" /> class.
        /// </summary>
        /// <param name="imageUrls">
        /// Array of image URLs for the effect.
        /// </param>
        /// <param name="effectScene">
        /// Effect scene type to apply.
        /// </param>
        public EffectsInput(
            global::System.Collections.Generic.IList<string> imageUrls,
            global::G.EffectsInputEffectScene effectScene)
        {
            this.ImageUrls = imageUrls ?? throw new global::System.ArgumentNullException(nameof(imageUrls));
            this.EffectScene = effectScene;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EffectsInput" /> class.
        /// </summary>
        public EffectsInput()
        {
        }
    }
}