//HintName: G.JsonConverters.ResearchOperationDtoClass.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResearchOperationDtoClassJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResearchOperationDtoClass>
    {
        /// <inheritdoc />
        public override global::G.ResearchOperationDtoClass Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchOperationDtoClassDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchOperationDtoClassDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchOperationDtoClassDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.ResearchOperationDtoClassVariant1? think = default;
            if (discriminator?.Type == global::G.ResearchOperationDtoClassDiscriminatorType.Think)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchOperationDtoClassVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchOperationDtoClassVariant1> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchOperationDtoClassVariant1)}");
                think = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResearchOperationDtoClassVariant2? search = default;
            if (discriminator?.Type == global::G.ResearchOperationDtoClassDiscriminatorType.Search)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchOperationDtoClassVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchOperationDtoClassVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchOperationDtoClassVariant2)}");
                search = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ResearchOperationDtoClassVariant3? crawl = default;
            if (discriminator?.Type == global::G.ResearchOperationDtoClassDiscriminatorType.Crawl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchOperationDtoClassVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchOperationDtoClassVariant3> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ResearchOperationDtoClassVariant3)}");
                crawl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ResearchOperationDtoClass(
                discriminator?.Type,
                think,

                search,

                crawl
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResearchOperationDtoClass value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsThink)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchOperationDtoClassVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchOperationDtoClassVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchOperationDtoClassVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Think!, typeInfo);
            }
            else if (value.IsSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchOperationDtoClassVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchOperationDtoClassVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchOperationDtoClassVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Search!, typeInfo);
            }
            else if (value.IsCrawl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResearchOperationDtoClassVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResearchOperationDtoClassVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResearchOperationDtoClassVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Crawl!, typeInfo);
            }
        }
    }
}