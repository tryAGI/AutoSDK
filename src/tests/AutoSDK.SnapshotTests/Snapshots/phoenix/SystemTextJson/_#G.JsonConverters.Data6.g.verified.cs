//HintName: G.JsonConverters.Data6.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Data6JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Data6>
    {
        /// <inheritdoc />
        public override global::G.Data6 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.UpdateAnnotationConfigResponseBodyDataDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.UpdateAnnotationConfigResponseBodyDataDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.UpdateAnnotationConfigResponseBodyDataDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CategoricalAnnotationConfig? categorical = default;
            if (discriminator?.Type == global::G.UpdateAnnotationConfigResponseBodyDataDiscriminatorType.Categorical)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CategoricalAnnotationConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CategoricalAnnotationConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CategoricalAnnotationConfig)}");
                categorical = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ContinuousAnnotationConfig? continuous = default;
            if (discriminator?.Type == global::G.UpdateAnnotationConfigResponseBodyDataDiscriminatorType.Continuous)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContinuousAnnotationConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContinuousAnnotationConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ContinuousAnnotationConfig)}");
                continuous = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.FreeformAnnotationConfig? freeform = default;
            if (discriminator?.Type == global::G.UpdateAnnotationConfigResponseBodyDataDiscriminatorType.Freeform)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FreeformAnnotationConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FreeformAnnotationConfig> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.FreeformAnnotationConfig)}");
                freeform = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Data6(
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
            global::G.Data6 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCategorical)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CategoricalAnnotationConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CategoricalAnnotationConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CategoricalAnnotationConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Categorical, typeInfo);
            }
            else if (value.IsContinuous)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ContinuousAnnotationConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ContinuousAnnotationConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ContinuousAnnotationConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Continuous, typeInfo);
            }
            else if (value.IsFreeform)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FreeformAnnotationConfig), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FreeformAnnotationConfig?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FreeformAnnotationConfig).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Freeform, typeInfo);
            }
        }
    }
}