//HintName: G.JsonConverters.GenerateAssetPublicGenerationsPostRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GenerateAssetPublicGenerationsPostRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GenerateAssetPublicGenerationsPostRequest>
    {
        /// <inheritdoc />
        public override global::G.GenerateAssetPublicGenerationsPostRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateAssetPublicGenerationsPostRequestDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateAssetPublicGenerationsPostRequestDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateAssetPublicGenerationsPostRequestDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.GenerateVideoRequestInput? video = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.Video)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVideoRequestInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVideoRequestInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateVideoRequestInput)}");
                video = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateTextToSpeechRequest? textToSpeech = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.TextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateTextToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateTextToSpeechRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateTextToSpeechRequest)}");
                textToSpeech = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateTextToSoundRequest? textToSound = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.TextToSound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateTextToSoundRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateTextToSoundRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateTextToSoundRequest)}");
                textToSound = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateImageRequest? image = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateImageRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateImageRequest)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateImageUpscaleRequest? imageUpscale = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.ImageUpscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateImageUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateImageUpscaleRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateImageUpscaleRequest)}");
                imageUpscale = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateVideoUpscaleRequest? videoUpscale = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoUpscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVideoUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVideoUpscaleRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateVideoUpscaleRequest)}");
                videoUpscale = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateIsolatedAudioRequest? audioIsolation = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.AudioIsolation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateIsolatedAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateIsolatedAudioRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateIsolatedAudioRequest)}");
                audioIsolation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateSpeechToSpeechRequest? speechToSpeech = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.SpeechToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateSpeechToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateSpeechToSpeechRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateSpeechToSpeechRequest)}");
                speechToSpeech = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateVoiceCloneRequest? voiceClone = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VoiceClone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVoiceCloneRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVoiceCloneRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateVoiceCloneRequest)}");
                voiceClone = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateAudioFromVideoRequest? audioFromVideo = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.AudioFromVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateAudioFromVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateAudioFromVideoRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateAudioFromVideoRequest)}");
                audioFromVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateVideoWithAudioRequest? videoWithAudio = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoWithAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVideoWithAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVideoWithAudioRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateVideoWithAudioRequest)}");
                videoWithAudio = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateVideoToVideoRequest? videoToVideo = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.VideoToVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVideoToVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVideoToVideoRequest> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateVideoToVideoRequest)}");
                videoToVideo = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.GenerateMotionControlRequestInput? motionControl = default;
            if (discriminator?.Type == global::G.GenerateAssetPublicGenerationsPostRequestDiscriminatorType.MotionControl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateMotionControlRequestInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateMotionControlRequestInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.GenerateMotionControlRequestInput)}");
                motionControl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.GenerateAssetPublicGenerationsPostRequest(
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
            global::G.GenerateAssetPublicGenerationsPostRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVideoRequestInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVideoRequestInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateVideoRequestInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video!, typeInfo);
            }
            else if (value.IsTextToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateTextToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateTextToSpeechRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateTextToSpeechRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToSpeech!, typeInfo);
            }
            else if (value.IsTextToSound)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateTextToSoundRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateTextToSoundRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateTextToSoundRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextToSound!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateImageRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateImageRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateImageRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsImageUpscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateImageUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateImageUpscaleRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateImageUpscaleRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUpscale!, typeInfo);
            }
            else if (value.IsVideoUpscale)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVideoUpscaleRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVideoUpscaleRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateVideoUpscaleRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoUpscale!, typeInfo);
            }
            else if (value.IsAudioIsolation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateIsolatedAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateIsolatedAudioRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateIsolatedAudioRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioIsolation!, typeInfo);
            }
            else if (value.IsSpeechToSpeech)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateSpeechToSpeechRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateSpeechToSpeechRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateSpeechToSpeechRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SpeechToSpeech!, typeInfo);
            }
            else if (value.IsVoiceClone)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVoiceCloneRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVoiceCloneRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateVoiceCloneRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VoiceClone!, typeInfo);
            }
            else if (value.IsAudioFromVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateAudioFromVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateAudioFromVideoRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateAudioFromVideoRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioFromVideo!, typeInfo);
            }
            else if (value.IsVideoWithAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVideoWithAudioRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVideoWithAudioRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateVideoWithAudioRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoWithAudio!, typeInfo);
            }
            else if (value.IsVideoToVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateVideoToVideoRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateVideoToVideoRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateVideoToVideoRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.VideoToVideo!, typeInfo);
            }
            else if (value.IsMotionControl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerateMotionControlRequestInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerateMotionControlRequestInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerateMotionControlRequestInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MotionControl!, typeInfo);
            }
        }
    }
}