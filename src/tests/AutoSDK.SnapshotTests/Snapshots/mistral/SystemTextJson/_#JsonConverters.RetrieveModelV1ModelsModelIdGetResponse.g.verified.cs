//HintName: JsonConverters.RetrieveModelV1ModelsModelIdGetResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RetrieveModelV1ModelsModelIdGetResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RetrieveModelV1ModelsModelIdGetResponse>
    {
        /// <inheritdoc />
        public override global::G.RetrieveModelV1ModelsModelIdGetResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            global::G.RetrieveModelV1ModelsModelIdGetResponseDiscriminator? discriminator = default;
            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RetrieveModelV1ModelsModelIdGetResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RetrieveModelV1ModelsModelIdGetResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.RetrieveModelV1ModelsModelIdGetResponseDiscriminator)}");
            discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.BaseModelCard? baseCard = default;
            if (discriminator?.Type == global::G.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType.Base)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseModelCard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BaseModelCard)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.FTModelCard? fTCard = default;
            if (discriminator?.Type == global::G.RetrieveModelV1ModelsModelIdGetResponseDiscriminatorType.FineTuned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FTModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FTModelCard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FTModelCard)}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.RetrieveModelV1ModelsModelIdGetResponse(
                baseCard,
                fTCard
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RetrieveModelV1ModelsModelIdGetResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBaseCard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseModelCard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseModelCard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseCard, typeInfo);
            }
            else if (value.IsFTCard)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FTModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FTModelCard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FTModelCard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FTCard, typeInfo);
            }
        }
    }
}