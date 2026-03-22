//HintName: G.JsonConverters.CreateTextToImageRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateTextToImageRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateTextToImageRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateTextToImageRequest Read(
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
            if (__jsonProps.Contains("contentModeration")) __score0++;
            if (__jsonProps.Contains("model")) __score0++;
            if (__jsonProps.Contains("promptText")) __score0++;
            if (__jsonProps.Contains("ratio")) __score0++;
            if (__jsonProps.Contains("referenceImages")) __score0++;
            if (__jsonProps.Contains("seed")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("contentModeration")) __score1++;
            if (__jsonProps.Contains("model")) __score1++;
            if (__jsonProps.Contains("promptText")) __score1++;
            if (__jsonProps.Contains("ratio")) __score1++;
            if (__jsonProps.Contains("referenceImages")) __score1++;
            if (__jsonProps.Contains("seed")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("model")) __score2++;
            if (__jsonProps.Contains("promptText")) __score2++;
            if (__jsonProps.Contains("ratio")) __score2++;
            if (__jsonProps.Contains("referenceImages")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.CreateTextToImageRequestGen4ImageTurbo? gen4ImageTurbo = default;
            global::G.CreateTextToImageRequestGen4Image? gen4Image = default;
            global::G.CreateTextToImageRequestGemini25Flash? gemini25Flash = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToImageRequestGen4ImageTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToImageRequestGen4ImageTurbo> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToImageRequestGen4ImageTurbo).Name}");
                        gen4ImageTurbo = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToImageRequestGen4Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToImageRequestGen4Image> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToImageRequestGen4Image).Name}");
                        gen4Image = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToImageRequestGemini25Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToImageRequestGemini25Flash> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToImageRequestGemini25Flash).Name}");
                        gemini25Flash = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (gen4ImageTurbo == null && gen4Image == null && gemini25Flash == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToImageRequestGen4ImageTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToImageRequestGen4ImageTurbo> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToImageRequestGen4ImageTurbo).Name}");
                    gen4ImageTurbo = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToImageRequestGen4Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToImageRequestGen4Image> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToImageRequestGen4Image).Name}");
                    gen4Image = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToImageRequestGemini25Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToImageRequestGemini25Flash> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToImageRequestGemini25Flash).Name}");
                    gemini25Flash = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CreateTextToImageRequest(
                gen4ImageTurbo,

                gen4Image,

                gemini25Flash
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateTextToImageRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsGen4ImageTurbo)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToImageRequestGen4ImageTurbo), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToImageRequestGen4ImageTurbo?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToImageRequestGen4ImageTurbo).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen4ImageTurbo, typeInfo);
            }
            else if (value.IsGen4Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToImageRequestGen4Image), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToImageRequestGen4Image?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToImageRequestGen4Image).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gen4Image, typeInfo);
            }
            else if (value.IsGemini25Flash)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateTextToImageRequestGemini25Flash), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateTextToImageRequestGemini25Flash?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateTextToImageRequestGemini25Flash).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Gemini25Flash, typeInfo);
            }
        }
    }
}