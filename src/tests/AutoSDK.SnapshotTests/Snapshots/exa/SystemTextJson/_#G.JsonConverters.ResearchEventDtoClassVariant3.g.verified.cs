//HintName: G.JsonConverters.ResearchEventDtoClassVariant3.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResearchEventDtoClassVariant3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResearchEventDtoClassVariant3>
    {
        /// <inheritdoc />
        public override global::G.ResearchEventDtoClassVariant3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant3Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant3Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant3Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ResearchEventDtoClassVariant3Variant1? taskDefinition = default;
            if (discriminator?.EventType == "task-definition")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant3Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant3Variant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant3Variant1)}");
                taskDefinition = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResearchEventDtoClassVariant3Variant2? taskOperation = default;
            if (discriminator?.EventType == "task-operation")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant3Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant3Variant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant3Variant2)}");
                taskOperation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResearchEventDtoClassVariant3Variant3? taskOutput = default;
            if (discriminator?.EventType == "task-output")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant3Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant3Variant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant3Variant3)}");
                taskOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ResearchEventDtoClassVariant3(
                discriminator?.EventType,
                taskDefinition,

                taskOperation,

                taskOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResearchEventDtoClassVariant3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTaskDefinition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant3Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant3Variant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchEventDtoClassVariant3Variant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TaskDefinition!, typeInfo);
            }
            else if (value.IsTaskOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant3Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant3Variant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchEventDtoClassVariant3Variant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TaskOperation!, typeInfo);
            }
            else if (value.IsTaskOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant3Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant3Variant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchEventDtoClassVariant3Variant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TaskOutput!, typeInfo);
            }
        }
    }
}