//HintName: G.Models.DubbingRenderResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DubbingRenderResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("render_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RenderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingRenderResponseModel" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="renderId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DubbingRenderResponseModel(
            int version,
            string renderId)
        {
            this.Version = version;
            this.RenderId = renderId ?? throw new global::System.ArgumentNullException(nameof(renderId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DubbingRenderResponseModel" /> class.
        /// </summary>
        public DubbingRenderResponseModel()
        {
        }
    }
}