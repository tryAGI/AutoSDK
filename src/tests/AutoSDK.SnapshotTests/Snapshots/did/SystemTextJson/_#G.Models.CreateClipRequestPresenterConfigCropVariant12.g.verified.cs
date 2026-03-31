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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateClipRequestPresenterConfigCropVariant1Type2JsonConverter))]
        public global::G.CreateClipRequestPresenterConfigCropVariant1Type2 Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateClipRequestPresenterConfigCropVariant12" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the crop.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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