//HintName: G.Models.CreateTextToImageRequestGemini25Flash.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTextToImageRequestGemini25Flash
    {
        /// <summary>
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptText")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptText { get; set; }

        /// <summary>
        /// The resolution of the output image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateTextToImageRequestGemini25FlashRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateTextToImageRequestGemini25FlashRatio Ratio { get; set; }

        /// <summary>
        /// An array of up to three images to be used as references for the generated image output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceImages")]
        public global::System.Collections.Generic.IList<global::G.CreateTextToImageRequestGemini25FlashReferenceImage>? ReferenceImages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"gemini_2.5_flash"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string Model { get; set; } = "gemini_2.5_flash";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGemini25Flash" /> class.
        /// </summary>
        /// <param name="promptText">
        /// A non-empty string up to 1000 characters (measured in UTF-16 code units). This should describe in detail what should appear in the output.
        /// </param>
        /// <param name="ratio">
        /// The resolution of the output image.
        /// </param>
        /// <param name="referenceImages">
        /// An array of up to three images to be used as references for the generated image output.
        /// </param>
        /// <param name="model"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTextToImageRequestGemini25Flash(
            string promptText,
            global::G.CreateTextToImageRequestGemini25FlashRatio ratio,
            global::System.Collections.Generic.IList<global::G.CreateTextToImageRequestGemini25FlashReferenceImage>? referenceImages,
            string model = "gemini_2.5_flash")
        {
            this.PromptText = promptText ?? throw new global::System.ArgumentNullException(nameof(promptText));
            this.Ratio = ratio;
            this.ReferenceImages = referenceImages;
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextToImageRequestGemini25Flash" /> class.
        /// </summary>
        public CreateTextToImageRequestGemini25Flash()
        {
        }
    }
}