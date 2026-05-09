//HintName: G.JsonConverters.ResearchEventDtoClassVariant1.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResearchEventDtoClassVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResearchEventDtoClassVariant1>
    {
        /// <inheritdoc />
        public override global::G.ResearchEventDtoClassVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ResearchEventDtoClassVariant1Variant1? researchDefinition = default;
            if (discriminator?.EventType == "research-definition")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant1Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant1Variant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant1Variant1)}");
                researchDefinition = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResearchEventDtoClassVariant1Variant2? researchOutput = default;
            if (discriminator?.EventType == "research-output")
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant1Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant1Variant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchEventDtoClassVariant1Variant2)}");
                researchOutput = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ResearchEventDtoClassVariant1(
                discriminator?.EventType,
                researchDefinition,

                researchOutput
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResearchEventDtoClassVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsResearchDefinition)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant1Variant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant1Variant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchEventDtoClassVariant1Variant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResearchDefinition!, typeInfo);
            }
            else if (value.IsResearchOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchEventDtoClassVariant1Variant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchEventDtoClassVariant1Variant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchEventDtoClassVariant1Variant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ResearchOutput!, typeInfo);
            }
        }
    }
}