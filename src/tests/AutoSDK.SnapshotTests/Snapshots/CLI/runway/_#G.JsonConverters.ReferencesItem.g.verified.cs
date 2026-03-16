//HintName: G.JsonConverters.ReferencesItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ReferencesItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReferencesItem>
    {
        /// <inheritdoc />
        public override global::G.ReferencesItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.RequestGen4AlephReferenceImageReference? image = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGen4AlephReferenceImageReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGen4AlephReferenceImageReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGen4AlephReferenceImageReference).Name}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var __value = new global::G.ReferencesItem(
                image
                );

            if (image != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGen4AlephReferenceImageReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGen4AlephReferenceImageReference> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGen4AlephReferenceImageReference).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReferencesItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RequestGen4AlephReferenceImageReference), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RequestGen4AlephReferenceImageReference?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RequestGen4AlephReferenceImageReference).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
        }
    }
}