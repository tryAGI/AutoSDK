//HintName: G.Models.GenerateVideoRequestOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerateVideoRequestOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Optional agent thread ID to associate this generation with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_thread_id")]
        public global::System.Guid? AgentThreadId { get; set; }

        /// <summary>
        /// Optional pre-reserved generation ID. If provided, this ID will be used instead of generating a new one. For batch operations (batch_size &gt; 1), use generation_ids instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_id")]
        public global::System.Guid? GenerationId { get; set; }

        /// <summary>
        /// Optional list of pre-reserved generation IDs for batch operations. Length must match batch_size. Mutually exclusive with generation_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? GenerationIds { get; set; }

        /// <summary>
        /// Default Value: video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// ID of the model to use for the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid AiModelId { get; set; }

        /// <summary>
        /// The id of the Image asset to use as the start keyframe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_keyframe_id")]
        public global::System.Guid? StartKeyframeId { get; set; }

        /// <summary>
        /// The URL of the image to use as the start keyframe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_keyframe_url")]
        public string? StartKeyframeUrl { get; set; }

        /// <summary>
        /// The id of the Image asset to use as the end keyframe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_keyframe_id")]
        public global::System.Guid? EndKeyframeId { get; set; }

        /// <summary>
        /// The URL of the image to use as the end keyframe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_keyframe_url")]
        public string? EndKeyframeUrl { get; set; }

        /// <summary>
        /// The id of the Audio asset to use, or a list of ids for multi-speaker generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>, object>))]
        public global::G.AnyOf<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>, object>? AudioId { get; set; }

        /// <summary>
        /// Optional TTS parameters for server-side audio generation. If provided (and audio_id is not), audio will be generated from these params before video generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_generation")]
        public global::G.GenerateTextToSpeechRequest? AudioGeneration { get; set; }

        /// <summary>
        /// Audio start offset in milliseconds. Negative values prepend silence (e.g., -1000 adds 1s silence before audio). Positive values crop from the beginning of the source audio (e.g., 2000 skips the first 2s). Use with generated_video_inputs.duration_ms to control total output length.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_start_ms")]
        public int? AudioStartMs { get; set; }

        /// <summary>
        /// The id(s) of the audio(s) to reference in the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_audio_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceAudioIds { get; set; }

        /// <summary>
        /// The id(s) of the image(s) to reference in the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceImageIds { get; set; }

        /// <summary>
        /// The id(s) of the video(s) to reference in the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_video_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceVideoIds { get; set; }

        /// <summary>
        /// The id of the Video asset to use as input. For V2V (motion control) models this is the driving video; for Google Veo models this triggers video extension.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_id")]
        public global::System.Guid? VideoId { get; set; }

        /// <summary>
        /// Inputs for generating the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_video_inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GeneratedVideoInputs GeneratedVideoInputs { get; set; }

        /// <summary>
        /// Number of video variations to generate (1-8). When &gt; 1, batch_results will contain all generation results.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoRequestOutput" /> class.
        /// </summary>
        /// <param name="aiModelId">
        /// ID of the model to use for the generation.
        /// </param>
        /// <param name="generatedVideoInputs">
        /// Inputs for generating the video.
        /// </param>
        /// <param name="workspaceId"></param>
        /// <param name="agentThreadId">
        /// Optional agent thread ID to associate this generation with.
        /// </param>
        /// <param name="generationId">
        /// Optional pre-reserved generation ID. If provided, this ID will be used instead of generating a new one. For batch operations (batch_size &gt; 1), use generation_ids instead.
        /// </param>
        /// <param name="generationIds">
        /// Optional list of pre-reserved generation IDs for batch operations. Length must match batch_size. Mutually exclusive with generation_id.
        /// </param>
        /// <param name="type">
        /// Default Value: video
        /// </param>
        /// <param name="startKeyframeId">
        /// The id of the Image asset to use as the start keyframe.
        /// </param>
        /// <param name="startKeyframeUrl">
        /// The URL of the image to use as the start keyframe.
        /// </param>
        /// <param name="endKeyframeId">
        /// The id of the Image asset to use as the end keyframe.
        /// </param>
        /// <param name="endKeyframeUrl">
        /// The URL of the image to use as the end keyframe.
        /// </param>
        /// <param name="audioId">
        /// The id of the Audio asset to use, or a list of ids for multi-speaker generation.
        /// </param>
        /// <param name="audioGeneration">
        /// Optional TTS parameters for server-side audio generation. If provided (and audio_id is not), audio will be generated from these params before video generation.
        /// </param>
        /// <param name="audioStartMs">
        /// Audio start offset in milliseconds. Negative values prepend silence (e.g., -1000 adds 1s silence before audio). Positive values crop from the beginning of the source audio (e.g., 2000 skips the first 2s). Use with generated_video_inputs.duration_ms to control total output length.
        /// </param>
        /// <param name="referenceAudioIds">
        /// The id(s) of the audio(s) to reference in the generation.
        /// </param>
        /// <param name="referenceImageIds">
        /// The id(s) of the image(s) to reference in the generation.
        /// </param>
        /// <param name="referenceVideoIds">
        /// The id(s) of the video(s) to reference in the generation.
        /// </param>
        /// <param name="videoId">
        /// The id of the Video asset to use as input. For V2V (motion control) models this is the driving video; for Google Veo models this triggers video extension.
        /// </param>
        /// <param name="batchSize">
        /// Number of video variations to generate (1-8). When &gt; 1, batch_results will contain all generation results.<br/>
        /// Default Value: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateVideoRequestOutput(
            global::System.Guid aiModelId,
            global::G.GeneratedVideoInputs generatedVideoInputs,
            string? workspaceId,
            global::System.Guid? agentThreadId,
            global::System.Guid? generationId,
            global::System.Collections.Generic.IList<global::System.Guid>? generationIds,
            string? type,
            global::System.Guid? startKeyframeId,
            string? startKeyframeUrl,
            global::System.Guid? endKeyframeId,
            string? endKeyframeUrl,
            global::G.AnyOf<global::System.Guid?, global::System.Collections.Generic.IList<global::System.Guid>, object>? audioId,
            global::G.GenerateTextToSpeechRequest? audioGeneration,
            int? audioStartMs,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceAudioIds,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceImageIds,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceVideoIds,
            global::System.Guid? videoId,
            int? batchSize)
        {
            this.WorkspaceId = workspaceId;
            this.AgentThreadId = agentThreadId;
            this.GenerationId = generationId;
            this.GenerationIds = generationIds;
            this.Type = type;
            this.AiModelId = aiModelId;
            this.StartKeyframeId = startKeyframeId;
            this.StartKeyframeUrl = startKeyframeUrl;
            this.EndKeyframeId = endKeyframeId;
            this.EndKeyframeUrl = endKeyframeUrl;
            this.AudioId = audioId;
            this.AudioGeneration = audioGeneration;
            this.AudioStartMs = audioStartMs;
            this.ReferenceAudioIds = referenceAudioIds;
            this.ReferenceImageIds = referenceImageIds;
            this.ReferenceVideoIds = referenceVideoIds;
            this.VideoId = videoId;
            this.GeneratedVideoInputs = generatedVideoInputs ?? throw new global::System.ArgumentNullException(nameof(generatedVideoInputs));
            this.BatchSize = batchSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateVideoRequestOutput" /> class.
        /// </summary>
        public GenerateVideoRequestOutput()
        {
        }
    }
}