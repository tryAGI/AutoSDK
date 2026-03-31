//HintName: G.JsonConverters.GeneratedAsset.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GeneratedAssetJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GeneratedAsset>
    {
        /// <inheritdoc />
        public override global::G.GeneratedAsset Read(
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
            if (__jsonProps.Contains("options")) __score0++;
            if (__jsonProps.Contains("provider")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("options")) __score1++;
            if (__jsonProps.Contains("provider")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("options")) __score2++;
            if (__jsonProps.Contains("provider")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("options")) __score3++;
            if (__jsonProps.Contains("provider")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("options")) __score4++;
            if (__jsonProps.Contains("provider")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("options")) __score5++;
            if (__jsonProps.Contains("provider")) __score5++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            global::G.ShotstackGeneratedAsset? shotstack = default;
            global::G.DIDGeneratedAsset? dId = default;
            global::G.ElevenLabsGeneratedAsset? elevenlabs = default;
            global::G.HeyGenGeneratedAsset? heygen = default;
            global::G.OpenAiGeneratedAsset? openai = default;
            global::G.StabilityAiGeneratedAsset? stabilityAi = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackGeneratedAsset> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShotstackGeneratedAsset).Name}");
                        shotstack = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DIDGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DIDGeneratedAsset> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DIDGeneratedAsset).Name}");
                        dId = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ElevenLabsGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ElevenLabsGeneratedAsset> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ElevenLabsGeneratedAsset).Name}");
                        elevenlabs = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HeyGenGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HeyGenGeneratedAsset> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HeyGenGeneratedAsset).Name}");
                        heygen = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiGeneratedAsset> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiGeneratedAsset).Name}");
                        openai = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StabilityAiGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StabilityAiGeneratedAsset> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StabilityAiGeneratedAsset).Name}");
                        stabilityAi = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (shotstack == null && dId == null && elevenlabs == null && heygen == null && openai == null && stabilityAi == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackGeneratedAsset> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShotstackGeneratedAsset).Name}");
                    shotstack = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DIDGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DIDGeneratedAsset> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DIDGeneratedAsset).Name}");
                    dId = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ElevenLabsGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ElevenLabsGeneratedAsset> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ElevenLabsGeneratedAsset).Name}");
                    elevenlabs = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HeyGenGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HeyGenGeneratedAsset> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HeyGenGeneratedAsset).Name}");
                    heygen = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiGeneratedAsset> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiGeneratedAsset).Name}");
                    openai = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StabilityAiGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StabilityAiGeneratedAsset> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StabilityAiGeneratedAsset).Name}");
                    stabilityAi = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.GeneratedAsset(
                shotstack,

                dId,

                elevenlabs,

                heygen,

                openai,

                stabilityAi
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GeneratedAsset value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsShotstack)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ShotstackGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ShotstackGeneratedAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ShotstackGeneratedAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shotstack!, typeInfo);
            }
            else if (value.IsDId)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DIDGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DIDGeneratedAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DIDGeneratedAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DId!, typeInfo);
            }
            else if (value.IsElevenlabs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ElevenLabsGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ElevenLabsGeneratedAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ElevenLabsGeneratedAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Elevenlabs!, typeInfo);
            }
            else if (value.IsHeygen)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HeyGenGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HeyGenGeneratedAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HeyGenGeneratedAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Heygen!, typeInfo);
            }
            else if (value.IsOpenai)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OpenAiGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OpenAiGeneratedAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OpenAiGeneratedAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Openai!, typeInfo);
            }
            else if (value.IsStabilityAi)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StabilityAiGeneratedAsset), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StabilityAiGeneratedAsset?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StabilityAiGeneratedAsset).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StabilityAi!, typeInfo);
            }
        }
    }
}