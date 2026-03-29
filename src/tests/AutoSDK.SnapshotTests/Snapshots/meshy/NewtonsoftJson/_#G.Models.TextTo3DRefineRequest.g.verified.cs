//HintName: G.Models.TextTo3DRefineRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextTo3DRefineRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public global::G.TextTo3DRefineRequestMode Mode { get; set; }

        /// <summary>
        /// ID of a SUCCEEDED preview task
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview_task_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PreviewTaskId { get; set; } = default!;

        /// <summary>
        /// Generate PBR texture maps<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_pbr")]
        public bool? EnablePbr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("texture_prompt")]
        public string? TexturePrompt { get; set; }

        /// <summary>
        /// URL or base64 data URI for texture guidance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("texture_image_url")]
        public string? TextureImageUrl { get; set; }

        /// <summary>
        /// Default Value: latest
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ai_model")]
        public global::G.AiModel? AiModel { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("moderation")]
        public bool? Moderation { get; set; }

        /// <summary>
        /// Remove highlights/shadows (meshy-6/latest only)<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remove_lighting")]
        public bool? RemoveLighting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target_formats")]
        public global::System.Collections.Generic.IList<global::G.TargetFormat3D>? TargetFormats { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_size")]
        public bool? AutoSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("origin_at")]
        public global::G.OriginAt? OriginAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTo3DRefineRequest" /> class.
        /// </summary>
        /// <param name="previewTaskId">
        /// ID of a SUCCEEDED preview task
        /// </param>
        /// <param name="mode"></param>
        /// <param name="enablePbr">
        /// Generate PBR texture maps<br/>
        /// Default Value: false
        /// </param>
        /// <param name="texturePrompt"></param>
        /// <param name="textureImageUrl">
        /// URL or base64 data URI for texture guidance
        /// </param>
        /// <param name="aiModel">
        /// Default Value: latest
        /// </param>
        /// <param name="moderation">
        /// Default Value: false
        /// </param>
        /// <param name="removeLighting">
        /// Remove highlights/shadows (meshy-6/latest only)<br/>
        /// Default Value: true
        /// </param>
        /// <param name="targetFormats"></param>
        /// <param name="autoSize">
        /// Default Value: false
        /// </param>
        /// <param name="originAt"></param>
        public TextTo3DRefineRequest(
            string previewTaskId,
            global::G.TextTo3DRefineRequestMode mode,
            bool? enablePbr,
            string? texturePrompt,
            string? textureImageUrl,
            global::G.AiModel? aiModel,
            bool? moderation,
            bool? removeLighting,
            global::System.Collections.Generic.IList<global::G.TargetFormat3D>? targetFormats,
            bool? autoSize,
            global::G.OriginAt? originAt)
        {
            this.Mode = mode;
            this.PreviewTaskId = previewTaskId ?? throw new global::System.ArgumentNullException(nameof(previewTaskId));
            this.EnablePbr = enablePbr;
            this.TexturePrompt = texturePrompt;
            this.TextureImageUrl = textureImageUrl;
            this.AiModel = aiModel;
            this.Moderation = moderation;
            this.RemoveLighting = removeLighting;
            this.TargetFormats = targetFormats;
            this.AutoSize = autoSize;
            this.OriginAt = originAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextTo3DRefineRequest" /> class.
        /// </summary>
        public TextTo3DRefineRequest()
        {
        }
    }
}