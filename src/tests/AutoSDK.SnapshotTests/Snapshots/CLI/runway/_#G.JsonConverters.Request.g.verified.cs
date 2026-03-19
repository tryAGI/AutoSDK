//HintName: G.JsonConverters.Request.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Request>
    {
        /// <inheritdoc />
        public override global::G.Request Read(
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
            if (__jsonProps.Contains("promptImage")) __score0++;
            if (__jsonProps.Contains("seed")) __score0++;
            if (__jsonProps.Contains("ratio")) __score0++;
            if (__jsonProps.Contains("duration")) __score0++;
            if (__jsonProps.Contains("contentModeration")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("promptText")) __score1++;
            if (__jsonProps.Contains("promptImage")) __score1++;
            if (__jsonProps.Contains("ratio")) __score1++;
            if (__jsonProps.Contains("audio")) __score1++;
            if (__jsonProps.Contains("duration")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("promptText")) __score2++;
            if (__jsonProps.Contains("promptImage")) __score2++;
            if (__jsonProps.Contains("seed")) __score2++;
            if (__jsonProps.Contains("duration")) __score2++;
            if (__jsonProps.Contains("ratio")) __score2++;
            if (__jsonProps.Contains("contentModeration")) __score2++;
            if (__jsonProps.Contains("model")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("promptText")) __score3++;
            if (__jsonProps.Contains("promptImage")) __score3++;
            if (__jsonProps.Contains("ratio")) __score3++;
            if (__jsonProps.Contains("audio")) __score3++;
            if (__jsonProps.Contains("duration")) __score3++;
            if (__jsonProps.Contains("model")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("promptText")) __score4++;
            if (__jsonProps.Contains("promptImage")) __score4++;
            if (__jsonProps.Contains("duration")) __score4++;
            if (__jsonProps.Contains("ratio")) __score4++;
            if (__jsonProps.Contains("model")) __score4++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }

            global::G.RequestGen4Turbo? gen4Turbo = default;
            global::G.RequestVeo31? veo31 = default;
            global::G.RequestGen3aTurbo? gen3aTurbo = default;
            global::G.RequestVeo31Fast? veo31Fast = default;
            global::G.RequestVeo3? veo3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGen4Turbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGen4Turbo> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGen4Turbo).Name}");
                        gen4Turbo = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo31> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo31).Name}");
                        veo31 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGen3aTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGen3aTurbo> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGen3aTurbo).Name}");
                        gen3aTurbo = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo31Fast> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo31Fast).Name}");
                        veo31Fast = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo3).Name}");
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

            if (gen4Turbo == null && veo31 == null && gen3aTurbo == null && veo31Fast == null && veo3 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGen4Turbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGen4Turbo> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGen4Turbo).Name}");
                    gen4Turbo = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo31> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo31).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGen3aTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGen3aTurbo> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGen3aTurbo).Name}");
                    gen3aTurbo = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo31Fast> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo31Fast).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo3).Name}");
                    veo3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Request(
                gen4Turbo,

                veo31,

                gen3aTurbo,

                veo31Fast,

                veo3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Request value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGen4Turbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGen4Turbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGen4Turbo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGen4Turbo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen4Turbo, typeInfo);
            }
            else if (value.IsVeo31)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo31), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo31?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo31).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31, typeInfo);
            }
            else if (value.IsGen3aTurbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGen3aTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGen3aTurbo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGen3aTurbo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen3aTurbo, typeInfo);
            }
            else if (value.IsVeo31Fast)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo31Fast), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo31Fast?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo31Fast).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo31Fast, typeInfo);
            }
            else if (value.IsVeo3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestVeo3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestVeo3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestVeo3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Veo3, typeInfo);
            }
        }
    }
}