//HintName: G.Models.ClipPresenterConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClipPresenterConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crop")]
        public global::G.AnyOf<global::G.ClipPresenterConfigCropVariant1, global::G.ClipPresenterConfigCropVariant2>? Crop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipPresenterConfig" /> class.
        /// </summary>
        /// <param name="crop"></param>
        public ClipPresenterConfig(
            global::G.AnyOf<global::G.ClipPresenterConfigCropVariant1, global::G.ClipPresenterConfigCropVariant2>? crop)
        {
            this.Crop = crop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipPresenterConfig" /> class.
        /// </summary>
        public ClipPresenterConfig()
        {
        }
    }
}