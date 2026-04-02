//HintName: G.JsonConverters.ExpressiveAvatarDto.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ExpressiveAvatarDtoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ExpressiveAvatarDto>
    {
        /// <inheritdoc />
        public override global::G.ExpressiveAvatarDto Read(
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
            if (__jsonProps.Contains("gender")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("is_greenscreen")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("owner_id")) __score0++;
            if (__jsonProps.Contains("thumbnail_url")) __score0++;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ExpressiveAvatarDtoVariant1? expressiveAvatarDtoVariant1 = default;
            object? expressiveAvatarDtoVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        expressiveAvatarDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExpressiveAvatarDtoVariant1>(__rawJson, options);
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
                        expressiveAvatarDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (expressiveAvatarDtoVariant1 == null && expressiveAvatarDtoVariant2 == null)
            {
                try
                {
                    expressiveAvatarDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.ExpressiveAvatarDtoVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    expressiveAvatarDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<object>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ExpressiveAvatarDto(
                expressiveAvatarDtoVariant1,

                expressiveAvatarDtoVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ExpressiveAvatarDto value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsExpressiveAvatarDtoVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExpressiveAvatarDtoVariant1, typeof(global::G.ExpressiveAvatarDtoVariant1), options);
            }
            else if (value.IsExpressiveAvatarDtoVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ExpressiveAvatarDtoVariant2, typeof(object), options);
            }
        }
    }
}