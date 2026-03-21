//HintName: G.JsonConverters.CreateTextToVideoRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateTextToVideoRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateTextToVideoRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateTextToVideoRequest Read(
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
            if (__jsonProps.Contains("promptText")) __score0++;
            if (__jsonProps.Contains("ratio")) __score0++;
            if (__jsonProps.Contains("audio")) __score0++;
            if (__jsonProps.Contains("duration")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("promptText")) __score1++;
            if (__jsonProps.Contains("ratio")) __score1++;
            if (__jsonProps.Contains("audio")) __score1++;
            if (__jsonProps.Contains("duration")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("promptText")) __score2++;
            if (__jsonProps.Contains("duration")) __score2++;
            if (__jsonProps.Contains("ratio")) __score2++;
            if (__jsonProps.Contains("model")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.CreateTextToVideoRequestVeo31? veo31 = default;
            global::G.CreateTextToVideoRequestVeo31Fast? veo31Fast = default;
            global::G.CreateTextToVideoRequestVeo3? veo3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToVideoRequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToVideoRequestVeo31> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToVideoRequestVeo31).Name}");
                        veo31 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToVideoRequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToVideoRequestVeo31Fast> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToVideoRequestVeo31Fast).Name}");
                        veo31Fast = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToVideoRequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToVideoRequestVeo3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToVideoRequestVeo3).Name}");
                        veo3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (veo31 == null && veo31Fast == null && veo3 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToVideoRequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToVideoRequestVeo31> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToVideoRequestVeo31).Name}");
                    veo31 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToVideoRequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToVideoRequestVeo31Fast> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToVideoRequestVeo31Fast).Name}");
                    veo31Fast = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToVideoRequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToVideoRequestVeo3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToVideoRequestVeo3).Name}");
                    veo3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CreateTextToVideoRequest(
                veo31,

                veo31Fast,

                veo3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateTextToVideoRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsVeo31)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToVideoRequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToVideoRequestVeo31?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToVideoRequestVeo31).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31, typeInfo);
            }
            else if (value.IsVeo31Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToVideoRequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToVideoRequestVeo31Fast?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToVideoRequestVeo31Fast).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31Fast, typeInfo);
            }
            else if (value.IsVeo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToVideoRequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToVideoRequestVeo3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToVideoRequestVeo3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo3, typeInfo);
            }
        }
    }
}