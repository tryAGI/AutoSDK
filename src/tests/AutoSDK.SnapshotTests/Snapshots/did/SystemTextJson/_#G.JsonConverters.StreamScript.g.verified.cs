//HintName: G.JsonConverters.StreamScript.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class StreamScriptJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.StreamScript>
    {
        /// <inheritdoc />
        public override global::G.StreamScript Read(
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
            if (__jsonProps.Contains("input")) __score0++;
            if (__jsonProps.Contains("provider")) __score0++;
            if (__jsonProps.Contains("ssml")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("audio_url")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.StreamScriptVariant1? streamScriptVariant1 = default;
            global::G.StreamScriptVariant2? streamScriptVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamScriptVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamScriptVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamScriptVariant1).Name}");
                        streamScriptVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamScriptVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamScriptVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamScriptVariant2).Name}");
                        streamScriptVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (streamScriptVariant1 == null && streamScriptVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamScriptVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamScriptVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamScriptVariant1).Name}");
                    streamScriptVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamScriptVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamScriptVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamScriptVariant2).Name}");
                    streamScriptVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.StreamScript(
                streamScriptVariant1,

                streamScriptVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.StreamScript value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStreamScriptVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamScriptVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamScriptVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamScriptVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamScriptVariant1!, typeInfo);
            }
            else if (value.IsStreamScriptVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.StreamScriptVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.StreamScriptVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.StreamScriptVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StreamScriptVariant2!, typeInfo);
            }
        }
    }
}