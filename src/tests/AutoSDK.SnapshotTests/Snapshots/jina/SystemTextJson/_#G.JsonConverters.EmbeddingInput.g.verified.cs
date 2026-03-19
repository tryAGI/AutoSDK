//HintName: G.JsonConverters.EmbeddingInput.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EmbeddingInput>
    {
        /// <inheritdoc />
        public override global::G.EmbeddingInput Read(
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
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("input")) __score0++;
            if (__jsonProps.Contains("embedding_type")) __score0++;
            if (__jsonProps.Contains("task")) __score0++;
            if (__jsonProps.Contains("dimensions")) __score0++;
            if (__jsonProps.Contains("normalized")) __score0++;
            if (__jsonProps.Contains("late_chunking")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("model")) __score1++;
            if (__jsonProps.Contains("input")) __score1++;
            if (__jsonProps.Contains("embedding_type")) __score1++;
            if (__jsonProps.Contains("normalized")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("model")) __score2++;
            if (__jsonProps.Contains("input")) __score2++;
            if (__jsonProps.Contains("embedding_type")) __score2++;
            if (__jsonProps.Contains("normalized")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.TextEmbeddingInput? textEmbeddingInput = default;
            global::G.ImageEmbeddingInput? imageEmbeddingInput = default;
            global::G.MixedEmbeddingInput? mixedEmbeddingInput = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextEmbeddingInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextEmbeddingInput).Name}");
                        textEmbeddingInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageEmbeddingInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageEmbeddingInput).Name}");
                        imageEmbeddingInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MixedEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MixedEmbeddingInput> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MixedEmbeddingInput).Name}");
                        mixedEmbeddingInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (textEmbeddingInput == null && imageEmbeddingInput == null && mixedEmbeddingInput == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextEmbeddingInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextEmbeddingInput).Name}");
                    textEmbeddingInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageEmbeddingInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageEmbeddingInput).Name}");
                    imageEmbeddingInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MixedEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MixedEmbeddingInput> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MixedEmbeddingInput).Name}");
                    mixedEmbeddingInput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.EmbeddingInput(
                textEmbeddingInput,

                imageEmbeddingInput,

                mixedEmbeddingInput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EmbeddingInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTextEmbeddingInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextEmbeddingInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextEmbeddingInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEmbeddingInput, typeInfo);
            }
            else if (value.IsImageEmbeddingInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageEmbeddingInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageEmbeddingInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageEmbeddingInput, typeInfo);
            }
            else if (value.IsMixedEmbeddingInput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.MixedEmbeddingInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.MixedEmbeddingInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.MixedEmbeddingInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MixedEmbeddingInput, typeInfo);
            }
        }
    }
}