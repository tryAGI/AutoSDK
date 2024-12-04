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
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDetailsToolCallsObjectToolCallDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDetailsToolCallsObjectToolCallDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepDetailsToolCallsObjectToolCallDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.RunStepDetailsToolCallsCodeObject? codeInterpreter = default;
            if (discriminator?.Type == global::G.RunStepDetailsToolCallsObjectToolCallDiscriminatorType.CodeInterpreter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDetailsToolCallsCodeObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDetailsToolCallsCodeObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepDetailsToolCallsCodeObject)}");
                codeInterpreter = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RunStepDetailsToolCallsFileSearchObject? fileSearch = default;
            if (discriminator?.Type == global::G.RunStepDetailsToolCallsObjectToolCallDiscriminatorType.FileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDetailsToolCallsFileSearchObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDetailsToolCallsFileSearchObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepDetailsToolCallsFileSearchObject)}");
                fileSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.RunStepDetailsToolCallsFunctionObject? function = default;
            if (discriminator?.Type == global::G.RunStepDetailsToolCallsObjectToolCallDiscriminatorType.Function)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDetailsToolCallsFunctionObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDetailsToolCallsFunctionObject> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RunStepDetailsToolCallsFunctionObject)}");
                function = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.ToolCallsItem2(
                discriminator?.Type,
                codeInterpreter,
                fileSearch,
                function
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

            if (value.IsCodeInterpreter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDetailsToolCallsCodeObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDetailsToolCallsCodeObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepDetailsToolCallsCodeObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeInterpreter, typeInfo);
            }
            else if (value.IsFileSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDetailsToolCallsFileSearchObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDetailsToolCallsFileSearchObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepDetailsToolCallsFileSearchObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearch, typeInfo);
            }
            else if (value.IsFunction)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStepDetailsToolCallsFunctionObject), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStepDetailsToolCallsFunctionObject?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStepDetailsToolCallsFunctionObject).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Function, typeInfo);
            }
        }
    }
}