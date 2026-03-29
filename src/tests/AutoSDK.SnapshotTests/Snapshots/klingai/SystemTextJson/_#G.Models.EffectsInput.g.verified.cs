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
        [global::System.Text.Json.Serialization.JsonPropertyName("image_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ImageUrls { get; set; }

        /// <summary>
        /// Effect scene type to apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effect_scene")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EffectsInputEffectSceneJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EffectsInputEffectScene EffectScene { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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