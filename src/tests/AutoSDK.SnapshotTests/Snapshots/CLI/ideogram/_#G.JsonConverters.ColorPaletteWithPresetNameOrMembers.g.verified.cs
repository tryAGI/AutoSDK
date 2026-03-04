//HintName: G.JsonConverters.ColorPaletteWithPresetNameOrMembers.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ColorPaletteWithPresetNameOrMembersJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ColorPaletteWithPresetNameOrMembers>
    {
        /// <inheritdoc />
        public override global::G.ColorPaletteWithPresetNameOrMembers Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.ColorPaletteWithPresetName? colorPaletteWithPresetName = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ColorPaletteWithPresetName), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ColorPaletteWithPresetName> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ColorPaletteWithPresetName).Name}");
                colorPaletteWithPresetName = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.ColorPaletteWithMembers? colorPaletteWithMembers = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ColorPaletteWithMembers), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ColorPaletteWithMembers> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ColorPaletteWithMembers).Name}");
                colorPaletteWithMembers = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ColorPaletteWithPresetNameOrMembers(
                colorPaletteWithPresetName,
                colorPaletteWithMembers
                );

            if (colorPaletteWithPresetName != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ColorPaletteWithPresetName), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ColorPaletteWithPresetName> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ColorPaletteWithPresetName).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (colorPaletteWithMembers != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ColorPaletteWithMembers), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ColorPaletteWithMembers> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ColorPaletteWithMembers).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ColorPaletteWithPresetNameOrMembers value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsColorPaletteWithPresetName)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ColorPaletteWithPresetName), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ColorPaletteWithPresetName?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ColorPaletteWithPresetName).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ColorPaletteWithPresetName, typeInfo);
            }
            else if (value.IsColorPaletteWithMembers)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ColorPaletteWithMembers), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ColorPaletteWithMembers?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ColorPaletteWithMembers).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ColorPaletteWithMembers, typeInfo);
            }
        }
    }
}