//HintName: G.JsonConverters.CreateExpressiveResponseDto.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateExpressiveResponseDtoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateExpressiveResponseDto>
    {
        /// <inheritdoc />
        public override global::G.CreateExpressiveResponseDto Read(
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
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("object")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.CreateExpressiveResponseDtoVariant1? createExpressiveResponseDtoVariant1 = default;
            global::G.CreateExpressiveResponseDtoVariant2? createExpressiveResponseDtoVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        createExpressiveResponseDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateExpressiveResponseDtoVariant1>(__rawJson, options);
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
                        createExpressiveResponseDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateExpressiveResponseDtoVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (createExpressiveResponseDtoVariant1 == null && createExpressiveResponseDtoVariant2 == null)
            {
                try
                {
                    createExpressiveResponseDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateExpressiveResponseDtoVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    createExpressiveResponseDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateExpressiveResponseDtoVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CreateExpressiveResponseDto(
                createExpressiveResponseDtoVariant1,

                createExpressiveResponseDtoVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateExpressiveResponseDto value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsCreateExpressiveResponseDtoVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateExpressiveResponseDtoVariant1, typeof(global::G.CreateExpressiveResponseDtoVariant1), options);
            }
            else if (value.IsCreateExpressiveResponseDtoVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CreateExpressiveResponseDtoVariant2, typeof(global::G.CreateExpressiveResponseDtoVariant2), options);
            }
        }
    }
}