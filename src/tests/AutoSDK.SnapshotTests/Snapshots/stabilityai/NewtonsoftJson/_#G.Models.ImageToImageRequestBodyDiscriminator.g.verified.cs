//HintName: G.Models.ImageToImageRequestBodyDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageToImageRequestBodyDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("init_image_mode")]
        public global::G.ImageToImageRequestBodyDiscriminatorInitImageMode? InitImageMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToImageRequestBodyDiscriminator" /> class.
        /// </summary>
        /// <param name="initImageMode"></param>
        public ImageToImageRequestBodyDiscriminator(
            global::G.ImageToImageRequestBodyDiscriminatorInitImageMode? initImageMode)
        {
            this.InitImageMode = initImageMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToImageRequestBodyDiscriminator" /> class.
        /// </summary>
        public ImageToImageRequestBodyDiscriminator()
        {
        }
    }
}