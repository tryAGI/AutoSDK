//HintName: G.JsonConverters.ArtifactGrepTool.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ArtifactGrepToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ArtifactGrepTool>
    {
        /// <inheritdoc />
        public override global::G.ArtifactGrepTool Read(
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
            if (__jsonProps.Contains("category")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("description")) __score0++;
            if (__jsonProps.Contains("description_template")) __score0++;
            if (__jsonProps.Contains("enabled")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("input_schema")) __score0++;
            if (__jsonProps.Contains("lineage")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("permissions")) __score0++;
            if (__jsonProps.Contains("title")) __score0++;
            if (__jsonProps.Contains("tool_groups")) __score0++;
            if (__jsonProps.Contains("updated_at")) __score0++;
            if (__jsonProps.Contains("version")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ToolBase? @base = default;
            global::G.ArtifactGrepToolVariant2? artifactGrepToolVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolBase).Name}");
                        @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ArtifactGrepToolVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ArtifactGrepToolVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ArtifactGrepToolVariant2).Name}");
                        artifactGrepToolVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && artifactGrepToolVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolBase).Name}");
                    @base = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ArtifactGrepToolVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ArtifactGrepToolVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ArtifactGrepToolVariant2).Name}");
                    artifactGrepToolVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ArtifactGrepTool(
                @base,

                artifactGrepToolVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ArtifactGrepTool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base!, typeInfo);
            }
            else if (value.IsArtifactGrepToolVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ArtifactGrepToolVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ArtifactGrepToolVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ArtifactGrepToolVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ArtifactGrepToolVariant2!, typeInfo);
            }
        }
    }
}