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
            if (__jsonProps.Contains("aspect_ratio")) __score0++;
            if (__jsonProps.Contains("callback_url")) __score0++;
            if (__jsonProps.Contains("generation_type")) __score0++;
            if (__jsonProps.Contains("keyframes")) __score0++;
            if (__jsonProps.Contains("loop")) __score0++;
            if (__jsonProps.Contains("prompt")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("aspect_ratio")) __score1++;
            if (__jsonProps.Contains("callback_url")) __score1++;
            if (__jsonProps.Contains("character_ref")) __score1++;
            if (__jsonProps.Contains("generation_type")) __score1++;
            if (__jsonProps.Contains("image_ref")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            if (__jsonProps.Contains("modify_image_ref")) __score1++;
            if (__jsonProps.Contains("prompt")) __score1++;
            if (__jsonProps.Contains("style_ref")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.GenerationRequest? video = default;
            global::G.ImageGenerationRequest? image = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationRequest).Name}");
                        video = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageGenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageGenerationRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageGenerationRequest).Name}");
                        image = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (video == null && image == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationRequest).Name}");
                    video = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageGenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageGenerationRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageGenerationRequest).Name}");
                    image = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Request(
                video,

                image
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

            if (value.IsVideo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Video, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageGenerationRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageGenerationRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageGenerationRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
        }
    }
}