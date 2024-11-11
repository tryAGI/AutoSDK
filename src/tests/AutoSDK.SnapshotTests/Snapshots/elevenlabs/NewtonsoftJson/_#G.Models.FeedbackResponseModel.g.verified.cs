//HintName: G.Models.FeedbackResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("thumbs_up", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ThumbsUp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback", Required = global::Newtonsoft.Json.Required.Always)]
        public string Feedback { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emotions", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Emotions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inaccurate_clone", Required = global::Newtonsoft.Json.Required.Always)]
        public bool InaccurateClone { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("glitches", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Glitches { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_quality", Required = global::Newtonsoft.Json.Required.Always)]
        public bool AudioQuality { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("other", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Other { get; set; } = default!;

        /// <summary>
        /// Default Value: not_reviewed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("review_status")]
        public string? ReviewStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackResponseModel" /> class.
        /// </summary>
        /// <param name="thumbsUp"></param>
        /// <param name="feedback"></param>
        /// <param name="emotions"></param>
        /// <param name="inaccurateClone"></param>
        /// <param name="glitches"></param>
        /// <param name="audioQuality"></param>
        /// <param name="other"></param>
        /// <param name="reviewStatus">
        /// Default Value: not_reviewed
        /// </param>
        public FeedbackResponseModel(
            bool thumbsUp,
            string feedback,
            bool emotions,
            bool inaccurateClone,
            bool glitches,
            bool audioQuality,
            bool other,
            string? reviewStatus)
        {
            this.ThumbsUp = thumbsUp;
            this.Feedback = feedback ?? throw new global::System.ArgumentNullException(nameof(feedback));
            this.Emotions = emotions;
            this.InaccurateClone = inaccurateClone;
            this.Glitches = glitches;
            this.AudioQuality = audioQuality;
            this.Other = other;
            this.ReviewStatus = reviewStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackResponseModel" /> class.
        /// </summary>
        public FeedbackResponseModel()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.FeedbackResponseModel? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.FeedbackResponseModel>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.FeedbackResponseModel?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.FeedbackResponseModel?>(serializer.Deserialize<global::G.FeedbackResponseModel>(jsonReader));
        }

    }
}