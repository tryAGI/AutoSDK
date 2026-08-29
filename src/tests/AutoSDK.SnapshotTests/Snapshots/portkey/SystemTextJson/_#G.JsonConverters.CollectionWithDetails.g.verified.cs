//HintName: G.JsonConverters.CollectionWithDetails.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CollectionWithDetailsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CollectionWithDetails>
    {
        /// <inheritdoc />
        public override global::G.CollectionWithDetails Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::G.Collection? collection = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Collection), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Collection> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Collection).Name}");
                collection = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }

            global::G.CollectionWithDetailsVariant2? collectionWithDetailsVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CollectionWithDetailsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CollectionWithDetailsVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CollectionWithDetailsVariant2).Name}");
                collectionWithDetailsVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            var __value = new global::G.CollectionWithDetails(
                collection,

                collectionWithDetailsVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CollectionWithDetails value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsCollection)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Collection), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Collection?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Collection).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.Collection!, typeInfo);
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
            if (value.IsCollectionWithDetailsVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CollectionWithDetailsVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CollectionWithDetailsVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CollectionWithDetailsVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.CollectionWithDetailsVariant2!, typeInfo);
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