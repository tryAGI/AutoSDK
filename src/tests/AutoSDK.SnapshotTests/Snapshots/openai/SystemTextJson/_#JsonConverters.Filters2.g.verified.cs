//HintName: JsonConverters.Filters2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class Filters2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Filters2>
    {
        /// <inheritdoc />
        public override global::G.Filters2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.ComparisonFilter? comparisonFilter = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComparisonFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComparisonFilter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComparisonFilter).Name}");
                comparisonFilter = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.CompoundFilter? compoundFilter = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompoundFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompoundFilter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompoundFilter).Name}");
                compoundFilter = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.Filters2(
                comparisonFilter,
                compoundFilter
                );

            if (comparisonFilter != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComparisonFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComparisonFilter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComparisonFilter).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (compoundFilter != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompoundFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompoundFilter> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompoundFilter).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Filters2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsComparisonFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComparisonFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComparisonFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComparisonFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComparisonFilter, typeInfo);
            }
            else if (value.IsCompoundFilter)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompoundFilter), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompoundFilter?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompoundFilter).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CompoundFilter, typeInfo);
            }
        }
    }
}