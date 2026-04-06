//HintName: G.JsonConverters.ChatCompletionRequestUserMessageContentPart.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionRequestUserMessageContentPartJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatCompletionRequestUserMessageContentPart>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionRequestUserMessageContentPart Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("image_url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("input_audio")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("file")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.ChatCompletionRequestMessageContentPartText? textContentPart = default;
            global::G.ChatCompletionRequestMessageContentPartImage? imageContentPart = default;
            global::G.ChatCompletionRequestMessageContentPartAudio? audioContentPart = default;
            global::G.ChatCompletionRequestMessageContentPartFile? fileContentPart = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartText> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartText).Name}");
                        textContentPart = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartImage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartImage).Name}");
                        imageContentPart = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartAudio> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartAudio).Name}");
                        audioContentPart = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartFile> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartFile).Name}");
                        fileContentPart = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (textContentPart == null && imageContentPart == null && audioContentPart == null && fileContentPart == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartText> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartText).Name}");
                    textContentPart = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartImage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartImage).Name}");
                    imageContentPart = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartAudio> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartAudio).Name}");
                    audioContentPart = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartFile> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartFile).Name}");
                    fileContentPart = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatCompletionRequestUserMessageContentPart(
                textContentPart,

                imageContentPart,

                audioContentPart,

                fileContentPart
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatCompletionRequestUserMessageContentPart value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextContentPart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextContentPart!, typeInfo);
            }
            else if (value.IsImageContentPart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageContentPart!, typeInfo);
            }
            else if (value.IsAudioContentPart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AudioContentPart!, typeInfo);
            }
            else if (value.IsFileContentPart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartFile?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartFile).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileContentPart!, typeInfo);
            }
        }
    }
}