//HintName: G.JsonConverters.Output.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OutputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Output>
    {
        /// <inheritdoc />
        public override global::G.Output Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant1Variant2OutputDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant1Variant2OutputDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant1Variant2OutputDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1? completed = default;
            if (discriminator?.OutputType == global::G.ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType.Completed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1)}");
                completed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2? failed = default;
            if (discriminator?.OutputType == global::G.ResearchEventDtoClassVariant1Variant2OutputDiscriminatorOutputType.Failed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2)}");
                failed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Output(
                discriminator?.OutputType,
                completed,

                failed
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Output value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompleted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchEventDtoClassVariant1Variant2OutputVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Completed!, typeInfo);
            }
            else if (value.IsFailed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchEventDtoClassVariant1Variant2OutputVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failed!, typeInfo);
            }
        }
    }
}