//HintName: G.JsonConverters.EmbeddingMediaMetadata.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingMediaMetadataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EmbeddingMediaMetadata>
    {
        /// <inheritdoc />
        public override global::G.EmbeddingMediaMetadata Read(
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
            if (__jsonProps.Contains("input_filename")) __score0++;
            if (__jsonProps.Contains("input_type")) __score0++;
            if (__jsonProps.Contains("input_url")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("input_filename")) __score1++;
            if (__jsonProps.Contains("input_type")) __score1++;
            if (__jsonProps.Contains("input_url")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("duration")) __score2++;
            if (__jsonProps.Contains("embedding_options")) __score2++;
            if (__jsonProps.Contains("embedding_scopes")) __score2++;
            if (__jsonProps.Contains("end_offset_sec")) __score2++;
            if (__jsonProps.Contains("input_filename")) __score2++;
            if (__jsonProps.Contains("input_type")) __score2++;
            if (__jsonProps.Contains("input_url")) __score2++;
            if (__jsonProps.Contains("start_offset_sec")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("clip_length")) __score3++;
            if (__jsonProps.Contains("duration")) __score3++;
            if (__jsonProps.Contains("embedding_options")) __score3++;
            if (__jsonProps.Contains("embedding_scopes")) __score3++;
            if (__jsonProps.Contains("end_offset_sec")) __score3++;
            if (__jsonProps.Contains("input_filename")) __score3++;
            if (__jsonProps.Contains("input_type")) __score3++;
            if (__jsonProps.Contains("input_url")) __score3++;
            if (__jsonProps.Contains("start_offset_sec")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("input_type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.EmbeddingImageMetadata? embeddingImageMetadata = default;
            global::G.EmbeddingTextImageMetadata? embeddingTextImageMetadata = default;
            global::G.EmbeddingAudioMetadata? embeddingAudioMetadata = default;
            global::G.EmbeddingVideoMetadata? embeddingVideoMetadata = default;
            global::G.EmbeddingMultiInputMetadata? embeddingMultiInputMetadata = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbeddingImageMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbeddingImageMetadata> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbeddingImageMetadata).Name}");
                        embeddingImageMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbeddingTextImageMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbeddingTextImageMetadata> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbeddingTextImageMetadata).Name}");
                        embeddingTextImageMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbeddingAudioMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbeddingAudioMetadata> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbeddingAudioMetadata).Name}");
                        embeddingAudioMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbeddingVideoMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbeddingVideoMetadata> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbeddingVideoMetadata).Name}");
                        embeddingVideoMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbeddingMultiInputMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbeddingMultiInputMetadata> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbeddingMultiInputMetadata).Name}");
                        embeddingMultiInputMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (embeddingImageMetadata == null && embeddingTextImageMetadata == null && embeddingAudioMetadata == null && embeddingVideoMetadata == null && embeddingMultiInputMetadata == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbeddingImageMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbeddingImageMetadata> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbeddingImageMetadata).Name}");
                    embeddingImageMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbeddingTextImageMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbeddingTextImageMetadata> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbeddingTextImageMetadata).Name}");
                    embeddingTextImageMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbeddingAudioMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbeddingAudioMetadata> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbeddingAudioMetadata).Name}");
                    embeddingAudioMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbeddingVideoMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbeddingVideoMetadata> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbeddingVideoMetadata).Name}");
                    embeddingVideoMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbeddingMultiInputMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbeddingMultiInputMetadata> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbeddingMultiInputMetadata).Name}");
                    embeddingMultiInputMetadata = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.EmbeddingMediaMetadata(
                embeddingImageMetadata,

                embeddingTextImageMetadata,

                embeddingAudioMetadata,

                embeddingVideoMetadata,

                embeddingMultiInputMetadata
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EmbeddingMediaMetadata value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsEmbeddingImageMetadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbeddingImageMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbeddingImageMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbeddingImageMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingImageMetadata, typeInfo);
            }
            else if (value.IsEmbeddingTextImageMetadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbeddingTextImageMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbeddingTextImageMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbeddingTextImageMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingTextImageMetadata, typeInfo);
            }
            else if (value.IsEmbeddingAudioMetadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbeddingAudioMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbeddingAudioMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbeddingAudioMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingAudioMetadata, typeInfo);
            }
            else if (value.IsEmbeddingVideoMetadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbeddingVideoMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbeddingVideoMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbeddingVideoMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingVideoMetadata, typeInfo);
            }
            else if (value.IsEmbeddingMultiInputMetadata)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EmbeddingMultiInputMetadata), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EmbeddingMultiInputMetadata?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EmbeddingMultiInputMetadata).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EmbeddingMultiInputMetadata, typeInfo);
            }
        }
    }
}