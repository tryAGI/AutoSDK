//HintName: G.JsonConverters.CreateSoundEffectRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateSoundEffectRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateSoundEffectRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateSoundEffectRequest Read(
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
            if (__jsonProps.Contains("duration")) __score0++;
            if (__jsonProps.Contains("loop")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("promptText")) __score0++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }

            global::G.CreateSoundEffectRequestElevenTextToSoundV2? elevenTextToSoundV2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSoundEffectRequestElevenTextToSoundV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSoundEffectRequestElevenTextToSoundV2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSoundEffectRequestElevenTextToSoundV2).Name}");
                        elevenTextToSoundV2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (elevenTextToSoundV2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSoundEffectRequestElevenTextToSoundV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSoundEffectRequestElevenTextToSoundV2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSoundEffectRequestElevenTextToSoundV2).Name}");
                    elevenTextToSoundV2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CreateSoundEffectRequest(
                elevenTextToSoundV2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateSoundEffectRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsElevenTextToSoundV2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateSoundEffectRequestElevenTextToSoundV2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateSoundEffectRequestElevenTextToSoundV2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateSoundEffectRequestElevenTextToSoundV2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ElevenTextToSoundV2, typeInfo);
            }
        }
    }
}