//HintName: G.Models.CreateModelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelRequest
    {
        /// <summary>
        /// Model visibility, public will be shown in the discovery page, unlist allows anyone with the link to access, private only be visible to the creator<br/>
        /// Default Value: public
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateModelRequestVisibilityJsonConverter))]
        public global::G.CreateModelRequestVisibility? Visibility { get; set; }

        /// <summary>
        /// Model type, tts is for text to speech
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateModelRequestTypeJsonConverter))]
        public global::G.CreateModelRequestType Type { get; set; }

        /// <summary>
        /// Model title or name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Model description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Model cover image, this is required if the model is public<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_image")]
        public byte[]? CoverImage { get; set; }

        /// <summary>
        /// Model cover image, this is required if the model is public<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cover_imagename")]
        public string? CoverImagename { get; set; }

        /// <summary>
        /// Model train mode, for TTS model, fast means model instantly available after creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateModelRequestTrainModeJsonConverter))]
        public global::G.CreateModelRequestTrainMode TrainMode { get; set; }

        /// <summary>
        /// Upload voices files that will be used to tune the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<byte[]>, byte[]>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::System.Collections.Generic.IList<byte[]>, byte[]> Voices { get; set; }

        /// <summary>
        /// Texts corresponding to the voices, if unspecified, ASR will be performed on the voices<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texts")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>))]
        public global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? Texts { get; set; }

        /// <summary>
        /// Model tags
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string, object>))]
        public global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? Tags { get; set; }

        /// <summary>
        /// Enhance audio quality<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhance_audio_quality")]
        public bool? EnhanceAudioQuality { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelRequest" /> class.
        /// </summary>
        /// <param name="title">
        /// Model title or name
        /// </param>
        /// <param name="voices">
        /// Upload voices files that will be used to tune the model
        /// </param>
        /// <param name="visibility">
        /// Model visibility, public will be shown in the discovery page, unlist allows anyone with the link to access, private only be visible to the creator<br/>
        /// Default Value: public
        /// </param>
        /// <param name="type">
        /// Model type, tts is for text to speech
        /// </param>
        /// <param name="description">
        /// Model description<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="coverImage">
        /// Model cover image, this is required if the model is public<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="coverImagename">
        /// Model cover image, this is required if the model is public<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="trainMode">
        /// Model train mode, for TTS model, fast means model instantly available after creation
        /// </param>
        /// <param name="texts">
        /// Texts corresponding to the voices, if unspecified, ASR will be performed on the voices<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tags">
        /// Model tags
        /// </param>
        /// <param name="enhanceAudioQuality">
        /// Enhance audio quality<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelRequest(
            string title,
            global::G.AnyOf<global::System.Collections.Generic.IList<byte[]>, byte[]> voices,
            global::G.CreateModelRequestVisibility? visibility,
            global::G.CreateModelRequestType type,
            string? description,
            byte[]? coverImage,
            string? coverImagename,
            global::G.CreateModelRequestTrainMode trainMode,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? texts,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string, object>? tags,
            bool? enhanceAudioQuality)
        {
            this.Visibility = visibility;
            this.Type = type;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Description = description;
            this.CoverImage = coverImage;
            this.CoverImagename = coverImagename;
            this.TrainMode = trainMode;
            this.Voices = voices;
            this.Texts = texts;
            this.Tags = tags;
            this.EnhanceAudioQuality = enhanceAudioQuality;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelRequest" /> class.
        /// </summary>
        public CreateModelRequest()
        {
        }
    }
}