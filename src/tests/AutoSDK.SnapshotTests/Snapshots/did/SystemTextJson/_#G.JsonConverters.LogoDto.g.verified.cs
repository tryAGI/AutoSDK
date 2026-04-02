//HintName: G.JsonConverters.LogoDto.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class LogoDtoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.LogoDto>
    {
        /// <inheritdoc />
        public override global::G.LogoDto Read(
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
            if (__jsonProps.Contains("position")) __score0++;
            if (__jsonProps.Contains("url")) __score0++;
            var __score1 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.LogoDtoVariant1? logoDtoVariant1 = default;
            bool? logoDtoVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        logoDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LogoDtoVariant1>(__rawJson, options);
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
                        logoDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<bool>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (logoDtoVariant1 == null && logoDtoVariant2 == null)
            {
                try
                {
                    logoDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.LogoDtoVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    logoDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<bool>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.LogoDto(
                logoDtoVariant1,

                logoDtoVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.LogoDto value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsLogoDtoVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LogoDtoVariant1, typeof(global::G.LogoDtoVariant1), options);
            }
            else if (value.IsLogoDtoVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LogoDtoVariant2, typeof(bool), options);
            }
        }
    }
}