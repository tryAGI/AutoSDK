//HintName: G.Models.GeneratedVideoInputs.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratedVideoInputs
    {
        /// <summary>
        /// Prompt for video generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_prompt", Required = global::Newtonsoft.Json.Required.Always)]
        public string TextPrompt { get; set; } = default!;

        /// <summary>
        /// The id of the model used for generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ai_model_id")]
        public global::System.Guid? AiModelId { get; set; }

        /// <summary>
        /// Resolution for the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// Aspect ratio for the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Duration of the video in milliseconds.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Normalized coordinates for speaker position(s). A single point for single-speaker; a list for multi-speaker (one per speaker, same length as audio_id list).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bounding_box_target")]
        public global::G.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, object>? BoundingBoxTarget { get; set; }

        /// <summary>
        /// For motion control models: 'video' matches reference video orientation (better for complex motions, max 30s), 'image' preserves character image orientation (better for camera movements, max 10s).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("character_orientation")]
        public global::G.GeneratedVideoInputsCharacterOrientation2? CharacterOrientation { get; set; }

        /// <summary>
        /// If true, automatically enhance the prompt before generation.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enhance_prompt")]
        public bool? EnhancePrompt { get; set; }

        /// <summary>
        /// List of shots for multi-shot video generation. When provided, text_prompt is ignored and total duration is the sum of shot durations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("multi_prompt")]
        public global::System.Collections.Generic.IList<global::G.VideoShot>? MultiPrompt { get; set; }

        /// <summary>
        /// Shot type for multi-shot generation. Currently only 'customize' is supported.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shot_type")]
        public string? ShotType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedVideoInputs" /> class.
        /// </summary>
        /// <param name="textPrompt">
        /// Prompt for video generation.
        /// </param>
        /// <param name="aiModelId">
        /// The id of the model used for generation.
        /// </param>
        /// <param name="resolution">
        /// Resolution for the video.
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio for the video.
        /// </param>
        /// <param name="durationMs">
        /// Duration of the video in milliseconds.
        /// </param>
        /// <param name="boundingBoxTarget">
        /// Normalized coordinates for speaker position(s). A single point for single-speaker; a list for multi-speaker (one per speaker, same length as audio_id list).
        /// </param>
        /// <param name="characterOrientation">
        /// For motion control models: 'video' matches reference video orientation (better for complex motions, max 30s), 'image' preserves character image orientation (better for camera movements, max 10s).
        /// </param>
        /// <param name="enhancePrompt">
        /// If true, automatically enhance the prompt before generation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="multiPrompt">
        /// List of shots for multi-shot video generation. When provided, text_prompt is ignored and total duration is the sum of shot durations.
        /// </param>
        /// <param name="shotType">
        /// Shot type for multi-shot generation. Currently only 'customize' is supported.
        /// </param>
        public GeneratedVideoInputs(
            string textPrompt,
            global::System.Guid? aiModelId,
            string? resolution,
            string? aspectRatio,
            int? durationMs,
            global::G.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, object>? boundingBoxTarget,
            global::G.GeneratedVideoInputsCharacterOrientation2? characterOrientation,
            bool? enhancePrompt,
            global::System.Collections.Generic.IList<global::G.VideoShot>? multiPrompt,
            string? shotType)
        {
            this.TextPrompt = textPrompt ?? throw new global::System.ArgumentNullException(nameof(textPrompt));
            this.AiModelId = aiModelId;
            this.Resolution = resolution;
            this.AspectRatio = aspectRatio;
            this.DurationMs = durationMs;
            this.BoundingBoxTarget = boundingBoxTarget;
            this.CharacterOrientation = characterOrientation;
            this.EnhancePrompt = enhancePrompt;
            this.MultiPrompt = multiPrompt;
            this.ShotType = shotType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedVideoInputs" /> class.
        /// </summary>
        public GeneratedVideoInputs()
        {
        }
    }
}