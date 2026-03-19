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

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("name")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("members")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ColorPaletteWithPresetName? colorPaletteWithPresetName = default;
            global::G.ColorPaletteWithMembers? colorPaletteWithMembers = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ColorPaletteWithPresetName), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ColorPaletteWithPresetName> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ColorPaletteWithPresetName).Name}");
                        colorPaletteWithPresetName = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ColorPaletteWithMembers), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ColorPaletteWithMembers> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ColorPaletteWithMembers).Name}");
                        colorPaletteWithMembers = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (colorPaletteWithPresetName == null && colorPaletteWithMembers == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ColorPaletteWithPresetName), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ColorPaletteWithPresetName> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ColorPaletteWithPresetName).Name}");
                    colorPaletteWithPresetName = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ColorPaletteWithMembers), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ColorPaletteWithMembers> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ColorPaletteWithMembers).Name}");
                    colorPaletteWithMembers = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ColorPaletteWithPresetNameOrMembers(
                colorPaletteWithPresetName,

                colorPaletteWithMembers
                );

            return __value;
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