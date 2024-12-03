//HintName: G.Models.PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for FANTASY_AVATAR_GENERATION service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION
    {
        /// <summary>
        /// The input height of the images. Must be between 32 and 1024 and be a multiple of 8. Note: Input resolution is not always the same as output resolution due to upscaling from other features
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("imageHeight")]
        public int? ImageHeight { get; set; }

        /// <summary>
        /// The input height of the images. Must be between 32 and 1024 and be a multiple of 8. Note: Input resolution is not always the same as output resolution due to upscaling from other features
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("imageWidth")]
        public int? ImageWidth { get; set; }

        /// <summary>
        /// The number of images to generate. Must be between 1 and 8. If either width or height is over 768, must be between 1 and 4.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("numImages")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION" /> class.
        /// </summary>
        /// <param name="imageHeight">
        /// The input height of the images. Must be between 32 and 1024 and be a multiple of 8. Note: Input resolution is not always the same as output resolution due to upscaling from other features
        /// </param>
        /// <param name="imageWidth">
        /// The input height of the images. Must be between 32 and 1024 and be a multiple of 8. Note: Input resolution is not always the same as output resolution due to upscaling from other features
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate. Must be between 1 and 8. If either width or height is over 768, must be between 1 and 4.
        /// </param>
        public PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION(
            int? imageHeight,
            int? imageWidth,
            int? numImages)
        {
            this.ImageHeight = imageHeight;
            this.ImageWidth = imageWidth;
            this.NumImages = numImages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION()
        {
        }
    }
}