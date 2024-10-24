//HintName: JsonConverters.ToolCallsItem2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ToolCallsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ToolCallsItem2>
    {
        /// <inheritdoc />
        public override global::G.ToolCallsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.RunStepDeltaStepDetailsToolCallsCodeObject? runStepDeltaDetailsCodeObject = default;
            if (discriminator?.Type == global::G.RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType.CodeInterpreter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaStepDetailsToolCallsCodeObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaStepDetailsToolCallsCodeObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepDeltaStepDetailsToolCallsCodeObject)}");
                runStepDeltaDetailsCodeObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject? runStepDeltaDetailsFileSearchObject = default;
            if (discriminator?.Type == global::G.RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType.FileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject)}");
                runStepDeltaDetailsFileSearchObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RunStepDeltaStepDetailsToolCallsFunctionObject? runStepDeltaDetailsFunctionObject = default;
            if (discriminator?.Type == global::G.RunStepDeltaStepDetailsToolCallsObjectToolCallDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaStepDetailsToolCallsFunctionObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaStepDetailsToolCallsFunctionObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepDeltaStepDetailsToolCallsFunctionObject)}");
                runStepDeltaDetailsFunctionObject = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ToolCallsItem2(
                discriminator?.Type,
                runStepDeltaDetailsCodeObject,
                runStepDeltaDetailsFileSearchObject,
                runStepDeltaDetailsFunctionObject
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ToolCallsItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunStepDeltaDetailsCodeObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaStepDetailsToolCallsCodeObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaStepDetailsToolCallsCodeObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepDeltaStepDetailsToolCallsCodeObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStepDeltaDetailsCodeObject, typeInfo);
            }
            else if (value.IsRunStepDeltaDetailsFileSearchObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepDeltaStepDetailsToolCallsFileSearchObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStepDeltaDetailsFileSearchObject, typeInfo);
            }
            else if (value.IsRunStepDeltaDetailsFunctionObject)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDeltaStepDetailsToolCallsFunctionObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDeltaStepDetailsToolCallsFunctionObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepDeltaStepDetailsToolCallsFunctionObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStepDeltaDetailsFunctionObject, typeInfo);
            }
        }
    }
}