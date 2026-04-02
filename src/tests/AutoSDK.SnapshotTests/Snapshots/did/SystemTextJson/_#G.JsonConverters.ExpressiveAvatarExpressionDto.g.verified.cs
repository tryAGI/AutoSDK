//HintName: G.JsonConverters.ExpressiveAvatarExpressionDto.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ExpressiveAvatarExpressionDtoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ExpressiveAvatarExpressionDto>
    {
        /// <inheritdoc />
        public override global::G.ExpressiveAvatarExpressionDto Read(
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
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("preview_url")) __score0++;
            if (__jsonProps.Contains("sentiment")) __score0++;
            if (__jsonProps.Contains("voice")) __score0++;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ExpressiveAvatarExpressionDtoVariant1? expressiveAvatarExpressionDtoVariant1 = default;
            object? expressiveAvatarExpressionDtoVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        expressiveAvatarExpressionDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExpressiveAvatarExpressionDtoVariant1>(__rawJson, options);
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
                        expressiveAvatarExpressionDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (expressiveAvatarExpressionDtoVariant1 == null && expressiveAvatarExpressionDtoVariant2 == null)
            {
                try
                {
                    expressiveAvatarExpressionDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExpressiveAvatarExpressionDtoVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    expressiveAvatarExpressionDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ExpressiveAvatarExpressionDto(
                expressiveAvatarExpressionDtoVariant1,

                expressiveAvatarExpressionDtoVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ExpressiveAvatarExpressionDto value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsExpressiveAvatarExpressionDtoVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExpressiveAvatarExpressionDtoVariant1, typeof(global::G.ExpressiveAvatarExpressionDtoVariant1), options);
            }
            else if (value.IsExpressiveAvatarExpressionDtoVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExpressiveAvatarExpressionDtoVariant2, typeof(object), options);
            }
        }
    }
}