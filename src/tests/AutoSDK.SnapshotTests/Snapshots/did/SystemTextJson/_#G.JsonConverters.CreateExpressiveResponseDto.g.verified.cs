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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::G.CreateExpressiveResponseDtoVariant1? createExpressiveResponseDtoVariant1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateExpressiveResponseDtoVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateExpressiveResponseDtoVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateExpressiveResponseDtoVariant1).Name}");
                createExpressiveResponseDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::G.CreateExpressiveResponseDtoVariant2? createExpressiveResponseDtoVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateExpressiveResponseDtoVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateExpressiveResponseDtoVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateExpressiveResponseDtoVariant2).Name}");
                createExpressiveResponseDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsCreateExpressiveResponseDtoVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateExpressiveResponseDtoVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateExpressiveResponseDtoVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateExpressiveResponseDtoVariant1).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.CreateExpressiveResponseDtoVariant1!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsCreateExpressiveResponseDtoVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateExpressiveResponseDtoVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateExpressiveResponseDtoVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateExpressiveResponseDtoVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.CreateExpressiveResponseDtoVariant2!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}