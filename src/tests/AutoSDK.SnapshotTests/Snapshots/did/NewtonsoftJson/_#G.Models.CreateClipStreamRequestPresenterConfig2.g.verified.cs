//HintName: G.Models.CreateClipStreamRequestPresenterConfig2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Advanced presenter configuration options.
    /// </summary>
    public sealed partial class CreateClipStreamRequestPresenterConfig2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crop")]
        public global::G.AnyOf<global::G.CreateClipStreamRequestPresenterConfigCropVariant12, global::G.CreateClipStreamRequestPresenterConfigCropVariant22>? Crop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestPresenterConfig2" /> class.
        /// </summary>
        /// <param name="crop"></param>
        public CreateClipStreamRequestPresenterConfig2(
            global::G.AnyOf<global::G.CreateClipStreamRequestPresenterConfigCropVariant12, global::G.CreateClipStreamRequestPresenterConfigCropVariant22>? crop)
        {
            this.Crop = crop;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestPresenterConfig2" /> class.
        /// </summary>
        public CreateClipStreamRequestPresenterConfig2()
        {
        }
    }
}