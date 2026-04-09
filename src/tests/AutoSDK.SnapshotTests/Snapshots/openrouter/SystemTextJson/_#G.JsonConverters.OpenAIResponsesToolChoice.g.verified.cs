//HintName: G.JsonConverters.OpenAIResponsesToolChoice.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OpenAIResponsesToolChoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OpenAIResponsesToolChoice>
    {
        /// <inheritdoc />
        public override global::G.OpenAIResponsesToolChoice Read(
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
            var __score1 = 0;
            var __score2 = 0;
            var __score3 = 0;
            if (__jsonProps.Contains("name")) __score3++;
            if (__jsonProps.Contains("type")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("type")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.OpenAiResponsesToolChoice0? openAiResponsesToolChoice0 = default;
            global::G.OpenAiResponsesToolChoice1? openAiResponsesToolChoice1 = default;
            global::G.OpenAiResponsesToolChoice2? openAiResponsesToolChoice2 = default;
            global::G.OpenAiResponsesToolChoice3? openAiResponsesToolChoice3 = default;
            global::G.OpenAiResponsesToolChoice4? openAiResponsesToolChoice4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiResponsesToolChoice0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiResponsesToolChoice0> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiResponsesToolChoice0).Name}");
                        openAiResponsesToolChoice0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiResponsesToolChoice1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiResponsesToolChoice1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiResponsesToolChoice1).Name}");
                        openAiResponsesToolChoice1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiResponsesToolChoice2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiResponsesToolChoice2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiResponsesToolChoice2).Name}");
                        openAiResponsesToolChoice2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiResponsesToolChoice3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiResponsesToolChoice3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiResponsesToolChoice3).Name}");
                        openAiResponsesToolChoice3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiResponsesToolChoice4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiResponsesToolChoice4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiResponsesToolChoice4).Name}");
                        openAiResponsesToolChoice4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (openAiResponsesToolChoice0 == null && openAiResponsesToolChoice1 == null && openAiResponsesToolChoice2 == null && openAiResponsesToolChoice3 == null && openAiResponsesToolChoice4 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiResponsesToolChoice0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiResponsesToolChoice0> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiResponsesToolChoice0).Name}");
                    openAiResponsesToolChoice0 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiResponsesToolChoice1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiResponsesToolChoice1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiResponsesToolChoice1).Name}");
                    openAiResponsesToolChoice1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiResponsesToolChoice2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiResponsesToolChoice2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiResponsesToolChoice2).Name}");
                    openAiResponsesToolChoice2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiResponsesToolChoice3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiResponsesToolChoice3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiResponsesToolChoice3).Name}");
                    openAiResponsesToolChoice3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiResponsesToolChoice4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiResponsesToolChoice4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiResponsesToolChoice4).Name}");
                    openAiResponsesToolChoice4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.OpenAIResponsesToolChoice(
                openAiResponsesToolChoice0,

                openAiResponsesToolChoice1,

                openAiResponsesToolChoice2,

                openAiResponsesToolChoice3,

                openAiResponsesToolChoice4
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OpenAIResponsesToolChoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOpenAiResponsesToolChoice0)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiResponsesToolChoice0), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiResponsesToolChoice0> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiResponsesToolChoice0).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAiResponsesToolChoice0!.Value, typeInfo);
            }
            else if (value.IsOpenAiResponsesToolChoice1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiResponsesToolChoice1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiResponsesToolChoice1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiResponsesToolChoice1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAiResponsesToolChoice1!.Value, typeInfo);
            }
            else if (value.IsOpenAiResponsesToolChoice2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiResponsesToolChoice2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiResponsesToolChoice2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiResponsesToolChoice2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAiResponsesToolChoice2!.Value, typeInfo);
            }
            else if (value.IsOpenAiResponsesToolChoice3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiResponsesToolChoice3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiResponsesToolChoice3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiResponsesToolChoice3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAiResponsesToolChoice3!, typeInfo);
            }
            else if (value.IsOpenAiResponsesToolChoice4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiResponsesToolChoice4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiResponsesToolChoice4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiResponsesToolChoice4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OpenAiResponsesToolChoice4!, typeInfo);
            }
        }
    }
}