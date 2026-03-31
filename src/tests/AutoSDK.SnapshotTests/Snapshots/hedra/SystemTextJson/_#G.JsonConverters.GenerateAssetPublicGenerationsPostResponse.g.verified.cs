//HintName: G.JsonConverters.GenerateAssetPublicGenerationsPostResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GenerateAssetPublicGenerationsPostResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GenerateAssetPublicGenerationsPostResponse>
    {
        /// <inheritdoc />
        public override global::G.GenerateAssetPublicGenerationsPostResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateAssetPublicGenerationsPostResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateAssetPublicGenerationsPostResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateAssetPublicGenerationsPostResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.GenerateVideoResponse? video = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVideoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVideoResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateVideoResponse)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateTextToSpeechResponse? textToSpeech = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateTextToSpeechResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateTextToSpeechResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateTextToSpeechResponse)}");
                textToSpeech = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateTextToSoundResponse? textToSound = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.TextToSound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateTextToSoundResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateTextToSoundResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateTextToSoundResponse)}");
                textToSound = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateImageResponse? image = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateImageResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateImageResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateImageResponse)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateImageUpscaleResponse? imageUpscale = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.ImageUpscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateImageUpscaleResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateImageUpscaleResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateImageUpscaleResponse)}");
                imageUpscale = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateVideoUpscaleResponse? videoUpscale = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoUpscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVideoUpscaleResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVideoUpscaleResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateVideoUpscaleResponse)}");
                videoUpscale = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateIsolatedAudioResponse? audioIsolation = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.AudioIsolation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateIsolatedAudioResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateIsolatedAudioResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateIsolatedAudioResponse)}");
                audioIsolation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateSpeechToSpeechResponse? speechToSpeech = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.SpeechToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateSpeechToSpeechResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateSpeechToSpeechResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateSpeechToSpeechResponse)}");
                speechToSpeech = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateVoiceCloneResponse? voiceClone = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VoiceClone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVoiceCloneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVoiceCloneResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateVoiceCloneResponse)}");
                voiceClone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateAudioFromVideoResponse? audioFromVideo = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.AudioFromVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateAudioFromVideoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateAudioFromVideoResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateAudioFromVideoResponse)}");
                audioFromVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateVideoWithAudioResponse? videoWithAudio = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoWithAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVideoWithAudioResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVideoWithAudioResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateVideoWithAudioResponse)}");
                videoWithAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateVideoToVideoResponse? videoToVideo = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.VideoToVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVideoToVideoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVideoToVideoResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateVideoToVideoResponse)}");
                videoToVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateMotionControlResponse? motionControl = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostResponseDiscriminatorType.MotionControl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateMotionControlResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateMotionControlResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateMotionControlResponse)}");
                motionControl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.GenerateAssetPublicGenerationsPostResponse(
                discriminator?.Type,
                video,

                textToSpeech,

                textToSound,

                image,

                imageUpscale,

                videoUpscale,

                audioIsolation,

                speechToSpeech,

                voiceClone,

                audioFromVideo,

                videoWithAudio,

                videoToVideo,

                motionControl
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GenerateAssetPublicGenerationsPostResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVideoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVideoResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateVideoResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video!, typeInfo);
            }
            else if (value.IsTextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateTextToSpeechResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateTextToSpeechResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateTextToSpeechResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToSpeech!, typeInfo);
            }
            else if (value.IsTextToSound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateTextToSoundResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateTextToSoundResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateTextToSoundResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToSound!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateImageResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateImageResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateImageResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsImageUpscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateImageUpscaleResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateImageUpscaleResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateImageUpscaleResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUpscale!, typeInfo);
            }
            else if (value.IsVideoUpscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVideoUpscaleResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVideoUpscaleResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateVideoUpscaleResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoUpscale!, typeInfo);
            }
            else if (value.IsAudioIsolation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateIsolatedAudioResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateIsolatedAudioResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateIsolatedAudioResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioIsolation!, typeInfo);
            }
            else if (value.IsSpeechToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateSpeechToSpeechResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateSpeechToSpeechResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateSpeechToSpeechResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeechToSpeech!, typeInfo);
            }
            else if (value.IsVoiceClone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVoiceCloneResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVoiceCloneResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateVoiceCloneResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceClone!, typeInfo);
            }
            else if (value.IsAudioFromVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateAudioFromVideoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateAudioFromVideoResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateAudioFromVideoResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioFromVideo!, typeInfo);
            }
            else if (value.IsVideoWithAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVideoWithAudioResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVideoWithAudioResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateVideoWithAudioResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoWithAudio!, typeInfo);
            }
            else if (value.IsVideoToVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVideoToVideoResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVideoToVideoResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateVideoToVideoResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoToVideo!, typeInfo);
            }
            else if (value.IsMotionControl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateMotionControlResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateMotionControlResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateMotionControlResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MotionControl!, typeInfo);
            }
        }
    }
}