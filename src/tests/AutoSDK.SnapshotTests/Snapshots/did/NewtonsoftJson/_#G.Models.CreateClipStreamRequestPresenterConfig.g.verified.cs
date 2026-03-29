//HintName: G.Models.CreateClipStreamRequestPresenterConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Advanced presenter configuration options.
    /// </summary>
    public sealed partial class CreateClipStreamRequestPresenterConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crop")]
        public global::G.AnyOf<global::G.CreateClipStreamRequestPresenterConfigCropVariant1, global::G.CreateClipStreamRequestPresenterConfigCropVariant2>? Crop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestPresenterConfig" /> class.
        /// </summary>
        /// <param name="crop"></param>
        public CreateClipStreamRequestPresenterConfig(
            global::G.AnyOf<global::G.CreateClipStreamRequestPresenterConfigCropVariant1, global::G.CreateClipStreamRequestPresenterConfigCropVariant2>? crop)
        {
            this.Crop = crop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestPresenterConfig" /> class.
        /// </summary>
        public CreateClipStreamRequestPresenterConfig()
        {
        }
    }
}