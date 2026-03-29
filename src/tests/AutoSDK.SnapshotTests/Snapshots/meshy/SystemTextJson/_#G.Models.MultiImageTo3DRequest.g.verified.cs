//HintName: G.Models.MultiImageTo3DRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MultiImageTo3DRequest
    {
        /// <summary>
        /// 1-4 images (URLs or base64 data URIs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_urls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ImageUrls { get; set; }

        /// <summary>
        /// Default Value: latest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AiModelJsonConverter))]
        public global::G.AiModel? AiModel { get; set; }

        /// <summary>
        /// Default Value: triangle
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("topology")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TopologyJsonConverter))]
        public global::G.Topology? Topology { get; set; }

        /// <summary>
        /// Default Value: 30000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_polycount")]
        public int? TargetPolycount { get; set; }

        /// <summary>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("symmetry_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SymmetryModeJsonConverter))]
        public global::G.SymmetryMode? SymmetryMode { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("should_remesh")]
        public bool? ShouldRemesh { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_pre_remeshed_model")]
        public bool? SavePreRemeshedModel { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("should_texture")]
        public bool? ShouldTexture { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_pbr")]
        public bool? EnablePbr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pose_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PoseModeJsonConverter))]
        public global::G.PoseMode? PoseMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_prompt")]
        public string? TexturePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture_image_url")]
        public string? TextureImageUrl { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("moderation")]
        public bool? Moderation { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_enhancement")]
        public bool? ImageEnhancement { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_lighting")]
        public bool? RemoveLighting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_formats")]
        public global::System.Collections.Generic.IList<global::G.TargetFormat3D>? TargetFormats { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_size")]
        public bool? AutoSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("origin_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OriginAtJsonConverter))]
        public global::G.OriginAt? OriginAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiImageTo3DRequest" /> class.
        /// </summary>
        /// <param name="imageUrls">
        /// 1-4 images (URLs or base64 data URIs)
        /// </param>
        /// <param name="aiModel">
        /// Default Value: latest
        /// </param>
        /// <param name="topology">
        /// Default Value: triangle
        /// </param>
        /// <param name="targetPolycount">
        /// Default Value: 30000
        /// </param>
        /// <param name="symmetryMode">
        /// Default Value: auto
        /// </param>
        /// <param name="shouldRemesh">
        /// Default Value: false
        /// </param>
        /// <param name="savePreRemeshedModel">
        /// Default Value: false
        /// </param>
        /// <param name="shouldTexture">
        /// Default Value: true
        /// </param>
        /// <param name="enablePbr">
        /// Default Value: false
        /// </param>
        /// <param name="poseMode"></param>
        /// <param name="texturePrompt"></param>
        /// <param name="textureImageUrl"></param>
        /// <param name="moderation">
        /// Default Value: false
        /// </param>
        /// <param name="imageEnhancement">
        /// Default Value: true
        /// </param>
        /// <param name="removeLighting">
        /// Default Value: true
        /// </param>
        /// <param name="targetFormats"></param>
        /// <param name="autoSize">
        /// Default Value: false
        /// </param>
        /// <param name="originAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MultiImageTo3DRequest(
            global::System.Collections.Generic.IList<string> imageUrls,
            global::G.AiModel? aiModel,
            global::G.Topology? topology,
            int? targetPolycount,
            global::G.SymmetryMode? symmetryMode,
            bool? shouldRemesh,
            bool? savePreRemeshedModel,
            bool? shouldTexture,
            bool? enablePbr,
            global::G.PoseMode? poseMode,
            string? texturePrompt,
            string? textureImageUrl,
            bool? moderation,
            bool? imageEnhancement,
            bool? removeLighting,
            global::System.Collections.Generic.IList<global::G.TargetFormat3D>? targetFormats,
            bool? autoSize,
            global::G.OriginAt? originAt)
        {
            this.ImageUrls = imageUrls ?? throw new global::System.ArgumentNullException(nameof(imageUrls));
            this.AiModel = aiModel;
            this.Topology = topology;
            this.TargetPolycount = targetPolycount;
            this.SymmetryMode = symmetryMode;
            this.ShouldRemesh = shouldRemesh;
            this.SavePreRemeshedModel = savePreRemeshedModel;
            this.ShouldTexture = shouldTexture;
            this.EnablePbr = enablePbr;
            this.PoseMode = poseMode;
            this.TexturePrompt = texturePrompt;
            this.TextureImageUrl = textureImageUrl;
            this.Moderation = moderation;
            this.ImageEnhancement = imageEnhancement;
            this.RemoveLighting = removeLighting;
            this.TargetFormats = targetFormats;
            this.AutoSize = autoSize;
            this.OriginAt = originAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiImageTo3DRequest" /> class.
        /// </summary>
        public MultiImageTo3DRequest()
        {
        }
    }
}