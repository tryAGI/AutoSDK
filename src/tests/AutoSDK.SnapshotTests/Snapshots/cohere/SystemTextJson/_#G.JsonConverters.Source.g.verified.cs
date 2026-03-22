//HintName: G.JsonConverters.Source.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class SourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Source>
    {
        /// <inheritdoc />
        public override global::G.Source Read(
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
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("tool_output")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("document")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ToolSource? toolOutput = default;
            global::G.DocumentSource? document = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolSource> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolSource).Name}");
                        toolOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DocumentSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DocumentSource> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DocumentSource).Name}");
                        document = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (toolOutput == null && document == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolSource> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolSource).Name}");
                    toolOutput = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DocumentSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DocumentSource> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DocumentSource).Name}");
                    document = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.Source(
                toolOutput,

                document
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Source value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsToolOutput)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ToolSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ToolSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ToolSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ToolOutput, typeInfo);
            }
            else if (value.IsDocument)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DocumentSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DocumentSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DocumentSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Document, typeInfo);
            }
        }
    }
}