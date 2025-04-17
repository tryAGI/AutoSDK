//HintName: JsonConverters.DataItem2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class DataItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.DataItem2>
    {
        /// <inheritdoc />
        public override global::G.DataItem2 Read(
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

            global::G.BaseModelCard? @base = default;
            if (discriminator?.Type == global::G.ModelListDataItemDiscriminatorType.Base)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseModelCard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.BaseModelCard)}");
                @base = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.FTModelCard? fineTuned = default;
            if (discriminator?.Type == global::G.ModelListDataItemDiscriminatorType.FineTuned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FTModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FTModelCard> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FTModelCard)}");
                fineTuned = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::G.DataItem2(
                discriminator?.Type,
                @base,
                fineTuned
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.DataItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.BaseModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.BaseModelCard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.BaseModelCard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base, typeInfo);
            }
            else if (value.IsFineTuned)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FTModelCard), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FTModelCard?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FTModelCard).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FineTuned, typeInfo);
            }
        }
    }
}