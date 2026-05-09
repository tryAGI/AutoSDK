//HintName: G.JsonConverters.Output2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Output2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Output2>
    {
        /// <inheritdoc />
        public override global::G.Output2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant2Variant3OutputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant2Variant3OutputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant2Variant3OutputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1? tasks = default;
            if (discriminator?.OutputType == global::G.ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType.Tasks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1)}");
                tasks = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2? stop = default;
            if (discriminator?.OutputType == global::G.ResearchEventDtoClassVariant2Variant3OutputDiscriminatorOutputType.Stop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2)}");
                stop = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Output2(
                discriminator?.OutputType,
                tasks,

                stop
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Output2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsTasks)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchEventDtoClassVariant2Variant3OutputVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tasks!, typeInfo);
            }
            else if (value.IsStop)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchEventDtoClassVariant2Variant3OutputVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Stop!, typeInfo);
            }
        }
    }
}