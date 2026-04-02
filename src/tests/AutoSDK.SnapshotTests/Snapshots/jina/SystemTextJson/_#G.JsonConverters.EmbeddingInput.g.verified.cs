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
            if (__jsonProps.Contains("dimensions")) __score0++;
            if (__jsonProps.Contains("embedding_type")) __score0++;
            if (__jsonProps.Contains("input")) __score0++;
            if (__jsonProps.Contains("late_chunking")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("normalized")) __score0++;
            if (__jsonProps.Contains("task")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("embedding_type")) __score1++;
            if (__jsonProps.Contains("input")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            if (__jsonProps.Contains("normalized")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("embedding_type")) __score2++;
            if (__jsonProps.Contains("input")) __score2++;
            if (__jsonProps.Contains("model")) __score2++;
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
                        textEmbeddingInput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextEmbeddingInput>(__rawJson, options);
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
                        imageEmbeddingInput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageEmbeddingInput>(__rawJson, options);
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
                        mixedEmbeddingInput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MixedEmbeddingInput>(__rawJson, options);
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
                    textEmbeddingInput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.TextEmbeddingInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    imageEmbeddingInput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageEmbeddingInput>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    mixedEmbeddingInput = global::System.Text.Json.JsonSerializer.Deserialize<global::G.MixedEmbeddingInput>(__rawJson, options);
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

            if (value.IsTextEmbeddingInput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TextEmbeddingInput, typeof(global::G.TextEmbeddingInput), options);
            }
            else if (value.IsImageEmbeddingInput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageEmbeddingInput, typeof(global::G.ImageEmbeddingInput), options);
            }
            else if (value.IsMixedEmbeddingInput)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MixedEmbeddingInput, typeof(global::G.MixedEmbeddingInput), options);
            }
        }
    }
}