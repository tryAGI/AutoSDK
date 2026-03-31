//HintName: G.JsonConverters.CreateAnnotationConfigData.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CreateAnnotationConfigDataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateAnnotationConfigData>
    {
        /// <inheritdoc />
        public override global::G.CreateAnnotationConfigData Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CreateAnnotationConfigDataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CreateAnnotationConfigDataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CreateAnnotationConfigDataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CategoricalAnnotationConfigData? categorical = default;
            if (discriminator?.Type == global::G.CreateAnnotationConfigDataDiscriminatorType.Categorical)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CategoricalAnnotationConfigData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CategoricalAnnotationConfigData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CategoricalAnnotationConfigData)}");
                categorical = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ContinuousAnnotationConfigData? continuous = default;
            if (discriminator?.Type == global::G.CreateAnnotationConfigDataDiscriminatorType.Continuous)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContinuousAnnotationConfigData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContinuousAnnotationConfigData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ContinuousAnnotationConfigData)}");
                continuous = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.FreeformAnnotationConfigData? freeform = default;
            if (discriminator?.Type == global::G.CreateAnnotationConfigDataDiscriminatorType.Freeform)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FreeformAnnotationConfigData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FreeformAnnotationConfigData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FreeformAnnotationConfigData)}");
                freeform = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.CreateAnnotationConfigData(
                discriminator?.Type,
                categorical,

                continuous,

                freeform
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateAnnotationConfigData value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCategorical)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CategoricalAnnotationConfigData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CategoricalAnnotationConfigData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CategoricalAnnotationConfigData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Categorical!, typeInfo);
            }
            else if (value.IsContinuous)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContinuousAnnotationConfigData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContinuousAnnotationConfigData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContinuousAnnotationConfigData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Continuous!, typeInfo);
            }
            else if (value.IsFreeform)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FreeformAnnotationConfigData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FreeformAnnotationConfigData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FreeformAnnotationConfigData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Freeform!, typeInfo);
            }
        }
    }
}