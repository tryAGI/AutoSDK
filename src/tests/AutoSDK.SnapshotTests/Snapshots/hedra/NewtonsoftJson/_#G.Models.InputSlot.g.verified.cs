//HintName: G.Models.InputSlot.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A typed input slot describing one kind of input a model accepts.<br/>
    /// Each slot has a media type (image, video, audio) and a role that distinguishes<br/>
    /// it from other slots of the same type (e.g., start_frame vs end_frame vs reference).
    /// </summary>
    public sealed partial class InputSlot
    {
        /// <summary>
        /// Media type: 'image', 'video', or 'audio'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Semantic role distinguishing this slot (e.g., 'start_frame', 'end_frame', 'reference', 'audio_input', 'input_video').
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("role", Required = global::Newtonsoft.Json.Required.Always)]
        public string Role { get; set; } = default!;

        /// <summary>
        /// Whether this input is mandatory.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Maximum number of files for this slot.<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_count")]
        public int? MaxCount { get; set; }

        /// <summary>
        /// Maximum file size in bytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_file_size_bytes")]
        public long? MaxFileSizeBytes { get; set; }

        /// <summary>
        /// Minimum width or height in pixels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_dimension_px")]
        public int? MinDimensionPx { get; set; }

        /// <summary>
        /// Maximum width or height in pixels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_dimension_px")]
        public int? MaxDimensionPx { get; set; }

        /// <summary>
        /// Minimum duration in milliseconds (video/audio only).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min_duration_ms")]
        public int? MinDurationMs { get; set; }

        /// <summary>
        /// Maximum duration in milliseconds (video/audio only).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_duration_ms")]
        public int? MaxDurationMs { get; set; }

        /// <summary>
        /// Maximum combined duration across all files in this slot in milliseconds (video/audio only).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_total_duration_ms")]
        public int? MaxTotalDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputSlot" /> class.
        /// </summary>
        /// <param name="type">
        /// Media type: 'image', 'video', or 'audio'.
        /// </param>
        /// <param name="role">
        /// Semantic role distinguishing this slot (e.g., 'start_frame', 'end_frame', 'reference', 'audio_input', 'input_video').
        /// </param>
        /// <param name="required">
        /// Whether this input is mandatory.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxCount">
        /// Maximum number of files for this slot.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="maxFileSizeBytes">
        /// Maximum file size in bytes.
        /// </param>
        /// <param name="minDimensionPx">
        /// Minimum width or height in pixels.
        /// </param>
        /// <param name="maxDimensionPx">
        /// Maximum width or height in pixels.
        /// </param>
        /// <param name="minDurationMs">
        /// Minimum duration in milliseconds (video/audio only).
        /// </param>
        /// <param name="maxDurationMs">
        /// Maximum duration in milliseconds (video/audio only).
        /// </param>
        /// <param name="maxTotalDurationMs">
        /// Maximum combined duration across all files in this slot in milliseconds (video/audio only).
        /// </param>
        public InputSlot(
            string type,
            string role,
            bool? required,
            int? maxCount,
            long? maxFileSizeBytes,
            int? minDimensionPx,
            int? maxDimensionPx,
            int? minDurationMs,
            int? maxDurationMs,
            int? maxTotalDurationMs)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Required = required;
            this.MaxCount = maxCount;
            this.MaxFileSizeBytes = maxFileSizeBytes;
            this.MinDimensionPx = minDimensionPx;
            this.MaxDimensionPx = maxDimensionPx;
            this.MinDurationMs = minDurationMs;
            this.MaxDurationMs = maxDurationMs;
            this.MaxTotalDurationMs = maxTotalDurationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputSlot" /> class.
        /// </summary>
        public InputSlot()
        {
        }
    }
}