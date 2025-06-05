//HintName: G.JsonConverters.ModelIdsResponses.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ModelIdsResponsesJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ModelIdsResponses>
    {
        /// <inheritdoc />
        public override global::G.ModelIdsResponses Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.ModelIdsShared? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelIdsShared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelIdsShared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelIdsShared).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ModelIdsResponsesEnum? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelIdsResponsesEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelIdsResponsesEnum> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelIdsResponsesEnum).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ModelIdsResponses(
                value1,
                value2
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelIdsShared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelIdsShared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelIdsShared).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelIdsResponsesEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelIdsResponsesEnum> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelIdsResponsesEnum).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ModelIdsResponses value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelIdsShared), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelIdsShared> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelIdsShared).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelIdsResponsesEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelIdsResponsesEnum> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ModelIdsResponsesEnum).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}