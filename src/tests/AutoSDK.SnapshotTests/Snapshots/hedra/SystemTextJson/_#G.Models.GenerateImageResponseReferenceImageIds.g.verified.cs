//HintName: G.Models.GenerateImageResponseReferenceImageIds.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The id(s) of the image(s) to reference in the generation. This is only used for image-to-image generation and will supersede start_keyframe_id.
    /// </summary>
    public sealed partial class GenerateImageResponseReferenceImageIds
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}