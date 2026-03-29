//HintName: G.Models.CreateClipRequestPresenterConfigCropVariant12.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateClipRequestPresenterConfigCropVariant12
    {
        /// <summary>
        /// The type of the crop.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateClipRequestPresenterConfigCropVariant1Type2 Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequestPresenterConfigCropVariant12" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the crop.
        /// </param>
        public CreateClipRequestPresenterConfigCropVariant12(
            global::G.CreateClipRequestPresenterConfigCropVariant1Type2 type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequestPresenterConfigCropVariant12" /> class.
        /// </summary>
        public CreateClipRequestPresenterConfigCropVariant12()
        {
        }
    }
}