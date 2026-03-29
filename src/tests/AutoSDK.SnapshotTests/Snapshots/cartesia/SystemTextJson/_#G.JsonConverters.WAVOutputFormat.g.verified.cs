//HintName: G.JsonConverters.WAVOutputFormat.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class WAVOutputFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WAVOutputFormat>
    {
        /// <inheritdoc />
        public override global::G.WAVOutputFormat Read(
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
            if (__jsonProps.Contains("encoding")) __score0++;
            if (__jsonProps.Contains("sample_rate")) __score0++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }

            global::G.RawOutputFormat? rawOutputFormat = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RawOutputFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RawOutputFormat> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RawOutputFormat).Name}");
                        rawOutputFormat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (rawOutputFormat == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RawOutputFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RawOutputFormat> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RawOutputFormat).Name}");
                    rawOutputFormat = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.WAVOutputFormat(
                rawOutputFormat
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WAVOutputFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRawOutputFormat)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RawOutputFormat), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RawOutputFormat?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RawOutputFormat).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RawOutputFormat, typeInfo);
            }
        }
    }
}