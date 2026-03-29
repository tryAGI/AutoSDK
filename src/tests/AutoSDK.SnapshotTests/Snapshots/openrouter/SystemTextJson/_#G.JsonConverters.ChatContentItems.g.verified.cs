//HintName: G.JsonConverters.ChatContentItems.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatContentItemsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatContentItems>
    {
        /// <inheritdoc />
        public override global::G.ChatContentItems Read(
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
            if (__jsonProps.Contains("cache_control")) __score0++;
            if (__jsonProps.Contains("text")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("image_url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("input_audio")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __score3 = 0;
            var __score4 = 0;
            if (__jsonProps.Contains("file")) __score4++;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.ChatContentText? chatContentText = default;
            global::G.ChatContentImage? chatContentImage = default;
            global::G.ChatContentAudio? chatContentAudio = default;
            global::G.ChatContentItems3? chatContentItems3 = default;
            global::G.ChatContentFile? chatContentFile = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentText> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentText).Name}");
                        chatContentText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentImage> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentImage).Name}");
                        chatContentImage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentAudio> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentAudio).Name}");
                        chatContentAudio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentItems3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentItems3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentItems3).Name}");
                        chatContentItems3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentFile> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentFile).Name}");
                        chatContentFile = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (chatContentText == null && chatContentImage == null && chatContentAudio == null && chatContentItems3 == null && chatContentFile == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentText> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentText).Name}");
                    chatContentText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentImage> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentImage).Name}");
                    chatContentImage = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentAudio> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentAudio).Name}");
                    chatContentAudio = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentItems3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentItems3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentItems3).Name}");
                    chatContentItems3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentFile> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentFile).Name}");
                    chatContentFile = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ChatContentItems(
                chatContentText,

                chatContentImage,

                chatContentAudio,

                chatContentItems3,

                chatContentFile
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatContentItems value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsChatContentText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatContentText, typeInfo);
            }
            else if (value.IsChatContentImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentImage), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentImage?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentImage).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatContentImage, typeInfo);
            }
            else if (value.IsChatContentAudio)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentAudio), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentAudio?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentAudio).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatContentAudio, typeInfo);
            }
            else if (value.IsChatContentItems3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentItems3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentItems3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentItems3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatContentItems3, typeInfo);
            }
            else if (value.IsChatContentFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatContentFile), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatContentFile?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatContentFile).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChatContentFile, typeInfo);
            }
        }
    }
}