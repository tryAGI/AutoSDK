//HintName: G.JsonConverters.SvgFill.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class SvgFillJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SvgFill>
    {
        /// <inheritdoc />
        public override global::G.SvgFill Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgFillDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgFillDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgFillDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.SvgSolidFill? solid = default;
            if (discriminator?.Type == global::G.SvgFillDiscriminatorType.Solid)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgSolidFill), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgSolidFill> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgSolidFill)}");
                solid = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SvgLinearGradientFill? linear = default;
            if (discriminator?.Type == global::G.SvgFillDiscriminatorType.Linear)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgLinearGradientFill), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgLinearGradientFill> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgLinearGradientFill)}");
                linear = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SvgRadialGradientFill? radial = default;
            if (discriminator?.Type == global::G.SvgFillDiscriminatorType.Radial)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgRadialGradientFill), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgRadialGradientFill> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgRadialGradientFill)}");
                radial = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.SvgFill(
                discriminator?.Type,
                solid,

                linear,

                radial
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SvgFill value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSolid)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgSolidFill), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgSolidFill?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SvgSolidFill).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Solid, typeInfo);
            }
            else if (value.IsLinear)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgLinearGradientFill), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgLinearGradientFill?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SvgLinearGradientFill).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Linear, typeInfo);
            }
            else if (value.IsRadial)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgRadialGradientFill), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgRadialGradientFill?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SvgRadialGradientFill).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Radial, typeInfo);
            }
        }
    }
}