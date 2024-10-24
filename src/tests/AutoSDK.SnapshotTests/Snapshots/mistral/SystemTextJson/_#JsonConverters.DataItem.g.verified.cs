//HintName: JsonConverters.DataItem.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class DataItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.DataItem>
    {
        /// <inheritdoc />
        public override global::G.DataItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ModelListDataItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ModelListDataItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ModelListDataItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BaseModelCard? baseModelCard = default;
            if (discriminator?.Type == global::G.ModelListDataItemDiscriminatorType.Base)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseModelCard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BaseModelCard)}");
                baseModelCard = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.FTModelCard? fTModelCard = default;
            if (discriminator?.Type == global::G.ModelListDataItemDiscriminatorType.FineTuned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FTModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FTModelCard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FTModelCard)}");
                fTModelCard = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.DataItem(
                discriminator?.Type,
                baseModelCard,
                fTModelCard
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.DataItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBaseModelCard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseModelCard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseModelCard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseModelCard, typeInfo);
            }
            else if (value.IsFTModelCard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FTModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FTModelCard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FTModelCard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FTModelCard, typeInfo);
            }
        }
    }
}