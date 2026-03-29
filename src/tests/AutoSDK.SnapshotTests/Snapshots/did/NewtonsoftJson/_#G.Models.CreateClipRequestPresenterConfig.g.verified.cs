//HintName: G.Models.CreateClipRequestPresenterConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Advanced presenter configuration options.
    /// </summary>
    public sealed partial class CreateClipRequestPresenterConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crop")]
        public global::G.AnyOf<global::G.CreateClipRequestPresenterConfigCropVariant1, global::G.CreateClipRequestPresenterConfigCropVariant2>? Crop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequestPresenterConfig" /> class.
        /// </summary>
        /// <param name="crop"></param>
        public CreateClipRequestPresenterConfig(
            global::G.AnyOf<global::G.CreateClipRequestPresenterConfigCropVariant1, global::G.CreateClipRequestPresenterConfigCropVariant2>? crop)
        {
            this.Crop = crop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequestPresenterConfig" /> class.
        /// </summary>
        public CreateClipRequestPresenterConfig()
        {
        }
    }
}