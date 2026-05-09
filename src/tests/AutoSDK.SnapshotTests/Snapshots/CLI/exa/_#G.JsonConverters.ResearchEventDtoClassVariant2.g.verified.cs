//HintName: G.JsonConverters.ResearchEventDtoClassVariant2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResearchEventDtoClassVariant2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResearchEventDtoClassVariant2>
    {
        /// <inheritdoc />
        public override global::G.ResearchEventDtoClassVariant2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant2Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant2Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant2Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ResearchEventDtoClassVariant2Variant1? planDefinition = default;
            if (discriminator?.EventType == global::G.ResearchEventDtoClassVariant2DiscriminatorEventType.PlanDefinition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant2Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant2Variant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant2Variant1)}");
                planDefinition = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResearchEventDtoClassVariant2Variant2? planOperation = default;
            if (discriminator?.EventType == global::G.ResearchEventDtoClassVariant2DiscriminatorEventType.PlanOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant2Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant2Variant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant2Variant2)}");
                planOperation = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResearchEventDtoClassVariant2Variant3? planOutput = default;
            if (discriminator?.EventType == global::G.ResearchEventDtoClassVariant2DiscriminatorEventType.PlanOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant2Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant2Variant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant2Variant3)}");
                planOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ResearchEventDtoClassVariant2(
                discriminator?.EventType,
                planDefinition,

                planOperation,

                planOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResearchEventDtoClassVariant2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPlanDefinition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant2Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant2Variant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchEventDtoClassVariant2Variant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlanDefinition!, typeInfo);
            }
            else if (value.IsPlanOperation)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant2Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant2Variant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchEventDtoClassVariant2Variant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlanOperation!, typeInfo);
            }
            else if (value.IsPlanOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant2Variant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant2Variant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchEventDtoClassVariant2Variant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PlanOutput!, typeInfo);
            }
        }
    }
}