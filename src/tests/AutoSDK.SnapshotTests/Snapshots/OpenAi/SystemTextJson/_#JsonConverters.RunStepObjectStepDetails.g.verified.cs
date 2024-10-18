//HintName: JsonConverters.RunStepObjectStepDetails.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RunStepObjectStepDetailsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RunStepObjectStepDetails>
    {
        /// <inheritdoc />
        public override global::G.RunStepObjectStepDetails Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepObjectStepDetailsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepObjectStepDetailsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepObjectStepDetailsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.RunStepDetailsMessageCreationObject? messageCreation = default;
            if (discriminator?.Type == global::G.RunStepObjectStepDetailsDiscriminatorType.MessageCreation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDetailsMessageCreationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDetailsMessageCreationObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepDetailsMessageCreationObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RunStepDetailsToolCallsObject? toolCalls = default;
            if (discriminator?.Type == global::G.RunStepObjectStepDetailsDiscriminatorType.ToolCalls)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDetailsToolCallsObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDetailsToolCallsObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepDetailsToolCallsObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.RunStepObjectStepDetails(
                discriminator?.Type,
                messageCreation,
                toolCalls
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RunStepObjectStepDetails value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageCreation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDetailsMessageCreationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDetailsMessageCreationObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepDetailsMessageCreationObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageCreation, typeInfo);
            }
            else if (value.IsToolCalls)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDetailsToolCallsObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDetailsToolCallsObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepDetailsToolCallsObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCalls, typeInfo);
            }
        }
    }
}