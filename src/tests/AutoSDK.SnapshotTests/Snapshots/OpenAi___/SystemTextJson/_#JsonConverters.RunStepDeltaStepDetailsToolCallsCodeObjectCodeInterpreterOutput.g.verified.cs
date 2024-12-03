//HintName: JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput>
    {
        /// <inheritdoc />
        public override global::G.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject? logs = default;
            if (discriminator?.Type == global::G.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType.Logs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject)}");
                logs = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject? image = default;
            if (discriminator?.Type == global::G.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutputDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput(
                discriminator?.Type,
                logs,
                image
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RunStepDeltaStepDetailsToolCallsCodeObjectCodeInterpreterOutput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsLogs)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepDeltaStepDetailsToolCallsCodeOutputLogsObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Logs, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepDeltaStepDetailsToolCallsCodeOutputImageObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image, typeInfo);
            }
        }
    }
}