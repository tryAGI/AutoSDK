//HintName: G.JsonConverters.ChatCompletionRequestAssistantMessageContentPart.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ChatCompletionRequestAssistantMessageContentPartJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatCompletionRequestAssistantMessageContentPart>
    {
        /// <inheritdoc />
        public override global::G.ChatCompletionRequestAssistantMessageContentPart Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.ChatCompletionRequestMessageContentPartText? text = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartText).Name}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ChatCompletionRequestMessageContentPartRefusal? refusal = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartRefusal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartRefusal> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartRefusal).Name}");
                refusal = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ChatCompletionRequestAssistantMessageContentPart(
                text,
                refusal
                );

            if (text != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartText> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartText).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (refusal != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartRefusal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartRefusal> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartRefusal).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatCompletionRequestAssistantMessageContentPart value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
            else if (value.IsRefusal)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ChatCompletionRequestMessageContentPartRefusal), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ChatCompletionRequestMessageContentPartRefusal?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ChatCompletionRequestMessageContentPartRefusal).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Refusal, typeInfo);
            }
        }
    }
}