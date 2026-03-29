//HintName: G.Models.MaskingUsingMaskImageRequestBodyVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MaskingUsingMaskImageRequestBodyVariant1
    {
        /// <summary>
        /// An array of text prompts to use for generation.<br/>
        /// Due to how arrays are represented in `multipart/form-data` requests, prompts must adhear to the format `text_prompts[index][text|weight]`,<br/>
        /// where `index` is some integer used to tie the text and weight together.  While `index` does not have to be sequential, duplicate entries <br/>
        /// will override previous entries, so it is recommended to use sequential indices.<br/>
        /// Given a text prompt with the text `A lighthouse on a cliff` and a weight of `0.5`, it would be represented as:<br/>
        /// ```<br/>
        /// text_prompts[0][text]: "A lighthouse on a cliff"<br/>
        /// text_prompts[0][weight]: 0.5<br/>
        /// ```<br/>
        /// To add another prompt to that request simply provide the values under a new `index`:<br/>
        /// ```<br/>
        /// text_prompts[0][text]: "A lighthouse on a cliff"<br/>
        /// text_prompts[0][weight]: 0.5<br/>
        /// text_prompts[1][text]: "land, ground, dirt, grass"<br/>
        /// text_prompts[1][weight]: -0.9<br/>
        /// ```
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_prompts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.TextPrompt> TextPrompts { get; set; } = default!;

        /// <summary>
        /// Image used to initialize the diffusion process, in lieu of random noise.<br/>
        /// Example: &lt;image binary&gt;
        /// </summary>
        /// <example>&lt;image binary&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("init_image", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] InitImage { get; set; } = default!;

        /// <summary>
        /// Image used to initialize the diffusion process, in lieu of random noise.<br/>
        /// Example: &lt;image binary&gt;
        /// </summary>
        /// <example>&lt;image binary&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("init_imagename", Required = global::Newtonsoft.Json.Required.Always)]
        public string InitImagename { get; set; } = default!;

        /// <summary>
        /// For any given pixel, the mask determines the strength of generation on a linear scale.  This parameter determines where to source the mask from:<br/>
        /// - `MASK_IMAGE_WHITE` will use the white pixels of the mask_image as the mask, where white pixels are completely replaced and black pixels are unchanged<br/>
        /// - `MASK_IMAGE_BLACK` will use the black pixels of the mask_image as the mask, where black pixels are completely replaced and white pixels are unchanged<br/>
        /// - `INIT_IMAGE_ALPHA` will use the alpha channel of the init_image as the mask, where fully transparent pixels are completely replaced and fully opaque pixels are unchanged
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mask_source", Required = global::Newtonsoft.Json.Required.Always)]
        public string MaskSource { get; set; } = default!;

        /// <summary>
        /// Optional grayscale mask that allows for influence over which pixels are eligible for diffusion and at what strength. Must be the same dimensions as the `init_image`. Use the `mask_source` option to specify whether the white or black pixels should be inpainted.<br/>
        /// Example: &lt;image binary&gt;
        /// </summary>
        /// <example>&lt;image binary&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("mask_image", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] MaskImage { get; set; } = default!;

        /// <summary>
        /// Optional grayscale mask that allows for influence over which pixels are eligible for diffusion and at what strength. Must be the same dimensions as the `init_image`. Use the `mask_source` option to specify whether the white or black pixels should be inpainted.<br/>
        /// Example: &lt;image binary&gt;
        /// </summary>
        /// <example>&lt;image binary&gt;</example>
        [global::Newtonsoft.Json.JsonProperty("mask_imagename", Required = global::Newtonsoft.Json.Required.Always)]
        public string MaskImagename { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskingUsingMaskImageRequestBodyVariant1" /> class.
        /// </summary>
        /// <param name="textPrompts">
        /// An array of text prompts to use for generation.<br/>
        /// Due to how arrays are represented in `multipart/form-data` requests, prompts must adhear to the format `text_prompts[index][text|weight]`,<br/>
        /// where `index` is some integer used to tie the text and weight together.  While `index` does not have to be sequential, duplicate entries <br/>
        /// will override previous entries, so it is recommended to use sequential indices.<br/>
        /// Given a text prompt with the text `A lighthouse on a cliff` and a weight of `0.5`, it would be represented as:<br/>
        /// ```<br/>
        /// text_prompts[0][text]: "A lighthouse on a cliff"<br/>
        /// text_prompts[0][weight]: 0.5<br/>
        /// ```<br/>
        /// To add another prompt to that request simply provide the values under a new `index`:<br/>
        /// ```<br/>
        /// text_prompts[0][text]: "A lighthouse on a cliff"<br/>
        /// text_prompts[0][weight]: 0.5<br/>
        /// text_prompts[1][text]: "land, ground, dirt, grass"<br/>
        /// text_prompts[1][weight]: -0.9<br/>
        /// ```
        /// </param>
        /// <param name="initImage">
        /// Image used to initialize the diffusion process, in lieu of random noise.<br/>
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="initImagename">
        /// Image used to initialize the diffusion process, in lieu of random noise.<br/>
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="maskSource">
        /// For any given pixel, the mask determines the strength of generation on a linear scale.  This parameter determines where to source the mask from:<br/>
        /// - `MASK_IMAGE_WHITE` will use the white pixels of the mask_image as the mask, where white pixels are completely replaced and black pixels are unchanged<br/>
        /// - `MASK_IMAGE_BLACK` will use the black pixels of the mask_image as the mask, where black pixels are completely replaced and white pixels are unchanged<br/>
        /// - `INIT_IMAGE_ALPHA` will use the alpha channel of the init_image as the mask, where fully transparent pixels are completely replaced and fully opaque pixels are unchanged
        /// </param>
        /// <param name="maskImage">
        /// Optional grayscale mask that allows for influence over which pixels are eligible for diffusion and at what strength. Must be the same dimensions as the `init_image`. Use the `mask_source` option to specify whether the white or black pixels should be inpainted.<br/>
        /// Example: &lt;image binary&gt;
        /// </param>
        /// <param name="maskImagename">
        /// Optional grayscale mask that allows for influence over which pixels are eligible for diffusion and at what strength. Must be the same dimensions as the `init_image`. Use the `mask_source` option to specify whether the white or black pixels should be inpainted.<br/>
        /// Example: &lt;image binary&gt;
        /// </param>
        public MaskingUsingMaskImageRequestBodyVariant1(
            global::System.Collections.Generic.IList<global::G.TextPrompt> textPrompts,
            byte[] initImage,
            string initImagename,
            string maskSource,
            byte[] maskImage,
            string maskImagename)
        {
            this.TextPrompts = textPrompts ?? throw new global::System.ArgumentNullException(nameof(textPrompts));
            this.InitImage = initImage ?? throw new global::System.ArgumentNullException(nameof(initImage));
            this.InitImagename = initImagename ?? throw new global::System.ArgumentNullException(nameof(initImagename));
            this.MaskSource = maskSource ?? throw new global::System.ArgumentNullException(nameof(maskSource));
            this.MaskImage = maskImage ?? throw new global::System.ArgumentNullException(nameof(maskImage));
            this.MaskImagename = maskImagename ?? throw new global::System.ArgumentNullException(nameof(maskImagename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskingUsingMaskImageRequestBodyVariant1" /> class.
        /// </summary>
        public MaskingUsingMaskImageRequestBodyVariant1()
        {
        }
    }
}