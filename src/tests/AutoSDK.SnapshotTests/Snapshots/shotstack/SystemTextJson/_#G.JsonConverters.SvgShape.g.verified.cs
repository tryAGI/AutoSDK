//HintName: G.JsonConverters.SvgShape.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class SvgShapeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SvgShape>
    {
        /// <inheritdoc />
        public override global::G.SvgShape Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgShapeDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgShapeDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgShapeDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.SvgRectangleShape? rectangle = default;
            if (discriminator?.Type == global::G.SvgShapeDiscriminatorType.Rectangle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgRectangleShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgRectangleShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgRectangleShape)}");
                rectangle = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SvgCircleShape? circle = default;
            if (discriminator?.Type == global::G.SvgShapeDiscriminatorType.Circle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgCircleShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgCircleShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgCircleShape)}");
                circle = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SvgEllipseShape? ellipse = default;
            if (discriminator?.Type == global::G.SvgShapeDiscriminatorType.Ellipse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgEllipseShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgEllipseShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgEllipseShape)}");
                ellipse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SvgLineShape? line = default;
            if (discriminator?.Type == global::G.SvgShapeDiscriminatorType.Line)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgLineShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgLineShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgLineShape)}");
                line = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SvgPolygonShape? polygon = default;
            if (discriminator?.Type == global::G.SvgShapeDiscriminatorType.Polygon)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgPolygonShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgPolygonShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgPolygonShape)}");
                polygon = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SvgStarShape? star = default;
            if (discriminator?.Type == global::G.SvgShapeDiscriminatorType.Star)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgStarShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgStarShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgStarShape)}");
                star = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SvgArrowShape? arrow = default;
            if (discriminator?.Type == global::G.SvgShapeDiscriminatorType.Arrow)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgArrowShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgArrowShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgArrowShape)}");
                arrow = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SvgHeartShape? heart = default;
            if (discriminator?.Type == global::G.SvgShapeDiscriminatorType.Heart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgHeartShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgHeartShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgHeartShape)}");
                heart = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SvgCrossShape? cross = default;
            if (discriminator?.Type == global::G.SvgShapeDiscriminatorType.Cross)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgCrossShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgCrossShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgCrossShape)}");
                cross = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SvgRingShape? ring = default;
            if (discriminator?.Type == global::G.SvgShapeDiscriminatorType.Ring)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgRingShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgRingShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgRingShape)}");
                ring = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.SvgPathShape? path = default;
            if (discriminator?.Type == global::G.SvgShapeDiscriminatorType.Path)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgPathShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgPathShape> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.SvgPathShape)}");
                path = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.SvgShape(
                discriminator?.Type,
                rectangle,

                circle,

                ellipse,

                line,

                polygon,

                star,

                arrow,

                heart,

                cross,

                ring,

                path
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SvgShape value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRectangle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgRectangleShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgRectangleShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SvgRectangleShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Rectangle!, typeInfo);
            }
            else if (value.IsCircle)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgCircleShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgCircleShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SvgCircleShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Circle!, typeInfo);
            }
            else if (value.IsEllipse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgEllipseShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgEllipseShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SvgEllipseShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ellipse!, typeInfo);
            }
            else if (value.IsLine)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgLineShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgLineShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SvgLineShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Line!, typeInfo);
            }
            else if (value.IsPolygon)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgPolygonShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgPolygonShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SvgPolygonShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Polygon!, typeInfo);
            }
            else if (value.IsStar)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgStarShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgStarShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SvgStarShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Star!, typeInfo);
            }
            else if (value.IsArrow)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgArrowShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgArrowShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SvgArrowShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Arrow!, typeInfo);
            }
            else if (value.IsHeart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgHeartShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgHeartShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SvgHeartShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Heart!, typeInfo);
            }
            else if (value.IsCross)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgCrossShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgCrossShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SvgCrossShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Cross!, typeInfo);
            }
            else if (value.IsRing)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgRingShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgRingShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SvgRingShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Ring!, typeInfo);
            }
            else if (value.IsPath)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.SvgPathShape), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.SvgPathShape?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.SvgPathShape).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Path!, typeInfo);
            }
        }
    }
}