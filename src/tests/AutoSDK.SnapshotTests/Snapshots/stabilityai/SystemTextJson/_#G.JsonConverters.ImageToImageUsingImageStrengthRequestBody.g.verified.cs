//HintName: G.JsonConverters.ImageToImageUsingImageStrengthRequestBody.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ImageToImageUsingImageStrengthRequestBodyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ImageToImageUsingImageStrengthRequestBody>
    {
        /// <inheritdoc />
        public override global::G.ImageToImageUsingImageStrengthRequestBody Read(
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
            if (__jsonProps.Contains("image_strength")) __score0++;
            if (__jsonProps.Contains("init_image")) __score0++;
            if (__jsonProps.Contains("init_image_mode")) __score0++;
            if (__jsonProps.Contains("text_prompts")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("cfg_scale")) __score1++;
            if (__jsonProps.Contains("clip_guidance_preset")) __score1++;
            if (__jsonProps.Contains("sampler")) __score1++;
            if (__jsonProps.Contains("samples")) __score1++;
            if (__jsonProps.Contains("seed")) __score1++;
            if (__jsonProps.Contains("steps")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ImageToImageUsingImageStrengthRequestBodyVariant1? imageToImageUsingImageStrengthRequestBodyVariant1 = default;
            global::G.GenerationRequestOptionalParams? generationOptionalParams = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageToImageUsingImageStrengthRequestBodyVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageToImageUsingImageStrengthRequestBodyVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageToImageUsingImageStrengthRequestBodyVariant1).Name}");
                        imageToImageUsingImageStrengthRequestBodyVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequestOptionalParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequestOptionalParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationRequestOptionalParams).Name}");
                        generationOptionalParams = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (imageToImageUsingImageStrengthRequestBodyVariant1 == null && generationOptionalParams == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageToImageUsingImageStrengthRequestBodyVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageToImageUsingImageStrengthRequestBodyVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageToImageUsingImageStrengthRequestBodyVariant1).Name}");
                    imageToImageUsingImageStrengthRequestBodyVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequestOptionalParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequestOptionalParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationRequestOptionalParams).Name}");
                    generationOptionalParams = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ImageToImageUsingImageStrengthRequestBody(
                imageToImageUsingImageStrengthRequestBodyVariant1,

                generationOptionalParams
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ImageToImageUsingImageStrengthRequestBody value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImageToImageUsingImageStrengthRequestBodyVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageToImageUsingImageStrengthRequestBodyVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageToImageUsingImageStrengthRequestBodyVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageToImageUsingImageStrengthRequestBodyVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageToImageUsingImageStrengthRequestBodyVariant1!, typeInfo);
            }
            else if (value.IsGenerationOptionalParams)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GenerationRequestOptionalParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GenerationRequestOptionalParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GenerationRequestOptionalParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GenerationOptionalParams!, typeInfo);
            }
        }
    }
}