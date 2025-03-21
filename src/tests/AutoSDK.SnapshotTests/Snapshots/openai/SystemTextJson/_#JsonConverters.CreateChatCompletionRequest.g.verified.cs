//HintName: JsonConverters.CreateChatCompletionRequest.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateChatCompletionRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateChatCompletionRequest>
    {
        /// <inheritdoc />
        public override global::G.CreateChatCompletionRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.CreateModelResponseProperties? value1 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateModelResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateModelResponseProperties> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateModelResponseProperties).Name}");
                value1 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.CreateChatCompletionRequestVariant2? value2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateChatCompletionRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateChatCompletionRequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateChatCompletionRequestVariant2).Name}");
                value2 = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.CreateChatCompletionRequest(
                value1,
                value2
                );

            if (value1 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateModelResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateModelResponseProperties> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateModelResponseProperties).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (value2 != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateChatCompletionRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateChatCompletionRequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateChatCompletionRequestVariant2).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateChatCompletionRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateModelResponseProperties), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateModelResponseProperties> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateModelResponseProperties).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateChatCompletionRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateChatCompletionRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CreateChatCompletionRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}