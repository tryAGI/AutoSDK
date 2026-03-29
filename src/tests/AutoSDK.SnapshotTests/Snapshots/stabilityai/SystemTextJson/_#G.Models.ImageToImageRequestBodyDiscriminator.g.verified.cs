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
        [global::System.Text.Json.Serialization.JsonPropertyName("init_image_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageToImageRequestBodyDiscriminatorInitImageModeJsonConverter))]
        public global::G.ImageToImageRequestBodyDiscriminatorInitImageMode? InitImageMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageToImageRequestBodyDiscriminator" /> class.
        /// </summary>
        /// <param name="initImageMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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