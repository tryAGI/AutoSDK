//HintName: G.JsonConverters.GetExpressiveAvatarDto.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class GetExpressiveAvatarDtoJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetExpressiveAvatarDto>
    {
        /// <inheritdoc />
        public override global::G.GetExpressiveAvatarDto Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::G.AllOf<global::G.GetExpressiveAvatarDtoVariant1Variant1, object>? getExpressiveAvatarDtoVariant1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.GetExpressiveAvatarDtoVariant1Variant1, object>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.GetExpressiveAvatarDtoVariant1Variant1, object>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.GetExpressiveAvatarDtoVariant1Variant1, object>).Name}");
                getExpressiveAvatarDtoVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::G.GetExpressiveAvatarDtoVariant2? getExpressiveAvatarDtoVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetExpressiveAvatarDtoVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetExpressiveAvatarDtoVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetExpressiveAvatarDtoVariant2).Name}");
                getExpressiveAvatarDtoVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::G.GetExpressiveAvatarDto(
                getExpressiveAvatarDtoVariant1,

                getExpressiveAvatarDtoVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetExpressiveAvatarDto value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsGetExpressiveAvatarDtoVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AllOf<global::G.GetExpressiveAvatarDtoVariant1Variant1, object>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AllOf<global::G.GetExpressiveAvatarDtoVariant1Variant1, object>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AllOf<global::G.GetExpressiveAvatarDtoVariant1Variant1, object>).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.GetExpressiveAvatarDtoVariant1!.Value, typeInfo);
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
            if (value.IsGetExpressiveAvatarDtoVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.GetExpressiveAvatarDtoVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.GetExpressiveAvatarDtoVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.GetExpressiveAvatarDtoVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.GetExpressiveAvatarDtoVariant2!, typeInfo);
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