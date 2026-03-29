//HintName: G.Models.RetextureRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RetextureRequest
    {
        /// <summary>
        /// ID of completed task
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_task_id")]
        public string? InputTaskId { get; set; }

        /// <summary>
        /// Public URL or data URI (.glb/.gltf/.obj/.fbx/.stl)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_url")]
        public string? ModelUrl { get; set; }

        /// <summary>
        /// Text description for texture style
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_style_prompt")]
        public string? TextStylePrompt { get; set; }

        /// <summary>
        /// URL or data URI (.jpg/.jpeg/.png) for style reference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_style_url")]
        public string? ImageStyleUrl { get; set; }

        /// <summary>
        /// Default Value: latest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AiModelJsonConverter))]
        public global::G.AiModel? AiModel { get; set; }

        /// <summary>
        /// Preserve existing UV mapping<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_original_uv")]
        public bool? EnableOriginalUv { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_pbr")]
        public bool? EnablePbr { get; set; }

        /// <summary>
        /// Remove highlights/shadows (meshy-6/latest only)<br/>
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetextureRequest" /> class.
        /// </summary>
        /// <param name="inputTaskId">
        /// ID of completed task
        /// </param>
        /// <param name="modelUrl">
        /// Public URL or data URI (.glb/.gltf/.obj/.fbx/.stl)
        /// </param>
        /// <param name="textStylePrompt">
        /// Text description for texture style
        /// </param>
        /// <param name="imageStyleUrl">
        /// URL or data URI (.jpg/.jpeg/.png) for style reference
        /// </param>
        /// <param name="aiModel">
        /// Default Value: latest
        /// </param>
        /// <param name="enableOriginalUv">
        /// Preserve existing UV mapping<br/>
        /// Default Value: true
        /// </param>
        /// <param name="enablePbr">
        /// Default Value: false
        /// </param>
        /// <param name="removeLighting">
        /// Remove highlights/shadows (meshy-6/latest only)<br/>
        /// Default Value: true
        /// </param>
        /// <param name="targetFormats"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetextureRequest(
            string? inputTaskId,
            string? modelUrl,
            string? textStylePrompt,
            string? imageStyleUrl,
            global::G.AiModel? aiModel,
            bool? enableOriginalUv,
            bool? enablePbr,
            bool? removeLighting,
            global::System.Collections.Generic.IList<global::G.TargetFormat3D>? targetFormats)
        {
            this.InputTaskId = inputTaskId;
            this.ModelUrl = modelUrl;
            this.TextStylePrompt = textStylePrompt;
            this.ImageStyleUrl = imageStyleUrl;
            this.AiModel = aiModel;
            this.EnableOriginalUv = enableOriginalUv;
            this.EnablePbr = enablePbr;
            this.RemoveLighting = removeLighting;
            this.TargetFormats = targetFormats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetextureRequest" /> class.
        /// </summary>
        public RetextureRequest()
        {
        }
    }
}