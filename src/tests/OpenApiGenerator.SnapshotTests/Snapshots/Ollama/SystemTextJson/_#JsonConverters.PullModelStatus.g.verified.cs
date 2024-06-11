//HintName: JsonConverters.PullModelStatus.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public class PullModelStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PullModelStatus>
    {
        /// <inheritdoc />
        public override global::G.PullModelStatus Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            options.TypeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            string? value1 = default;
            try
            {
                var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.PullModelStatusVariant2? value2 = default;
            try
            {
                var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(global::G.PullModelStatusVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PullModelStatusVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PullModelStatusVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            var result = new global::G.PullModelStatus(
                value1,

                value2
                );
            if (!result.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid JSON format for AnyOf<{typeof(string).Name}, {typeof(global::G.PullModelStatusVariant2).Name}>");
            }

            if (value1 != null)
            {
                var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            else if (value2 != null)
            {
                var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(global::G.PullModelStatusVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PullModelStatusVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PullModelStatusVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PullModelStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            options.TypeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (!value.Validate())
            {
                throw new global::System.Text.Json.JsonException($"Invalid AnyOf<{typeof(string).Name}, {typeof(global::G.PullModelStatusVariant2).Name}> object.");
            }

            if (value.IsValue1)
            {
                var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }

            else if (value.IsValue2)
            {
                var typeInfo = options.TypeInfoResolver.GetTypeInfo(typeof(global::G.PullModelStatusVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PullModelStatusVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PullModelStatusVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}