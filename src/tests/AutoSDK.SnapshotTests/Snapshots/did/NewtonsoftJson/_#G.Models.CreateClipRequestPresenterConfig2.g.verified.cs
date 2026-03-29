//HintName: G.Models.CreateClipRequestPresenterConfig2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Advanced presenter configuration options.
    /// </summary>
    public sealed partial class CreateClipRequestPresenterConfig2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crop")]
        public global::G.AnyOf<global::G.CreateClipRequestPresenterConfigCropVariant12, global::G.CreateClipRequestPresenterConfigCropVariant22>? Crop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequestPresenterConfig2" /> class.
        /// </summary>
        /// <param name="crop"></param>
        public CreateClipRequestPresenterConfig2(
            global::G.AnyOf<global::G.CreateClipRequestPresenterConfigCropVariant12, global::G.CreateClipRequestPresenterConfigCropVariant22>? crop)
        {
            this.Crop = crop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequestPresenterConfig2" /> class.
        /// </summary>
        public CreateClipRequestPresenterConfig2()
        {
        }
    }
}