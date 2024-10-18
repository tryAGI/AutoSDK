//HintName: JsonConverters.RunStepDeltaObjectDeltaStepDetails.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RunStepDeltaObjectDeltaStepDetailsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RunStepDeltaObjectDeltaStepDetails>
    {
        /// <inheritdoc />
        public override global::G.RunStepDeltaObjectDeltaStepDetails Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaObjectDeltaStepDetailsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaObjectDeltaStepDetailsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepDeltaObjectDeltaStepDetailsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.RunStepDeltaStepDetailsMessageCreationObject? messageCreation = default;
            if (discriminator?.Type == global::G.RunStepDeltaObjectDeltaStepDetailsDiscriminatorType.MessageCreation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaStepDetailsMessageCreationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaStepDetailsMessageCreationObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepDeltaStepDetailsMessageCreationObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RunStepDeltaStepDetailsToolCallsObject? toolCalls = default;
            if (discriminator?.Type == global::G.RunStepDeltaObjectDeltaStepDetailsDiscriminatorType.ToolCalls)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaStepDetailsToolCallsObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaStepDetailsToolCallsObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepDeltaStepDetailsToolCallsObject)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.RunStepDeltaObjectDeltaStepDetails(
                discriminator?.Type,
                messageCreation,
                toolCalls
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RunStepDeltaObjectDeltaStepDetails value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsMessageCreation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaStepDetailsMessageCreationObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaStepDetailsMessageCreationObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepDeltaStepDetailsMessageCreationObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.MessageCreation, typeInfo);
            }
            else if (value.IsToolCalls)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaStepDetailsToolCallsObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaStepDetailsToolCallsObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepDeltaStepDetailsToolCallsObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolCalls, typeInfo);
            }
        }
    }
}