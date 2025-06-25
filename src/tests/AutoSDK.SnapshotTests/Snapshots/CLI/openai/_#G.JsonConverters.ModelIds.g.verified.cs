//HintName: G.JsonConverters.ModelIds.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ModelIdsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ModelIds>
    {
        /// <inheritdoc />
        public override global::G.ModelIds Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.ModelIdsShared? shared = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelIdsShared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelIdsShared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelIdsShared).Name}");
                shared = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ModelIdsResponses? responses = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelIdsResponses), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelIdsResponses> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelIdsResponses).Name}");
                responses = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ModelIds(
                shared,
                responses
                );

            if (shared != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelIdsShared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelIdsShared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelIdsShared).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (responses != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelIdsResponses), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelIdsResponses> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelIdsResponses).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ModelIds value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsShared)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelIdsShared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelIdsShared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelIdsShared).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Shared, typeInfo);
            }
            else if (value.IsResponses)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelIdsResponses), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelIdsResponses> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelIdsResponses).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Responses, typeInfo);
            }
        }
    }
}