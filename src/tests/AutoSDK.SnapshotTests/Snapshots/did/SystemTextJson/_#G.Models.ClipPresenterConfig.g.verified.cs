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
        [global::System.Text.Json.Serialization.JsonPropertyName("crop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.ClipPresenterConfigCropVariant1, global::G.ClipPresenterConfigCropVariant2>))]
        public global::G.AnyOf<global::G.ClipPresenterConfigCropVariant1, global::G.ClipPresenterConfigCropVariant2>? Crop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClipPresenterConfig" /> class.
        /// </summary>
        /// <param name="crop"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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