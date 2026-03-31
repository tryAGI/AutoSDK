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
        [global::System.Text.Json.Serialization.JsonPropertyName("crop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CreateClipStreamRequestPresenterConfigCropVariant1, global::G.CreateClipStreamRequestPresenterConfigCropVariant2>))]
        public global::G.AnyOf<global::G.CreateClipStreamRequestPresenterConfigCropVariant1, global::G.CreateClipStreamRequestPresenterConfigCropVariant2>? Crop { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipStreamRequestPresenterConfig" /> class.
        /// </summary>
        /// <param name="crop"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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