//HintName: G.JsonConverters.ReasoningDetailUnion.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ReasoningDetailUnionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReasoningDetailUnion>
    {
        /// <inheritdoc />
        public override global::G.ReasoningDetailUnion Read(
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
            if (__jsonProps.Contains("format")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("index")) __score0++;
            if (__jsonProps.Contains("summary")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("format")) __score1++;
            if (__jsonProps.Contains("id")) __score1++;
            if (__jsonProps.Contains("index")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("format")) __score2++;
            if (__jsonProps.Contains("id")) __score2++;
            if (__jsonProps.Contains("index")) __score2++;
            if (__jsonProps.Contains("signature")) __score2++;
            if (__jsonProps.Contains("text")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.ReasoningDetailSummary? reasoningDetailSummary = default;
            global::G.ReasoningDetailEncrypted? reasoningDetailEncrypted = default;
            global::G.ReasoningDetailText? reasoningDetailText = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningDetailSummary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningDetailSummary> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningDetailSummary).Name}");
                        reasoningDetailSummary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningDetailEncrypted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningDetailEncrypted> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningDetailEncrypted).Name}");
                        reasoningDetailEncrypted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 2)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningDetailText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningDetailText> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningDetailText).Name}");
                        reasoningDetailText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (reasoningDetailSummary == null && reasoningDetailEncrypted == null && reasoningDetailText == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningDetailSummary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningDetailSummary> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningDetailSummary).Name}");
                    reasoningDetailSummary = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningDetailEncrypted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningDetailEncrypted> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningDetailEncrypted).Name}");
                    reasoningDetailEncrypted = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningDetailText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningDetailText> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningDetailText).Name}");
                    reasoningDetailText = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ReasoningDetailUnion(
                reasoningDetailSummary,

                reasoningDetailEncrypted,

                reasoningDetailText
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReasoningDetailUnion value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsReasoningDetailSummary)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningDetailSummary), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningDetailSummary?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningDetailSummary).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningDetailSummary, typeInfo);
            }
            else if (value.IsReasoningDetailEncrypted)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningDetailEncrypted), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningDetailEncrypted?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningDetailEncrypted).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningDetailEncrypted, typeInfo);
            }
            else if (value.IsReasoningDetailText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ReasoningDetailText), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ReasoningDetailText?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ReasoningDetailText).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ReasoningDetailText, typeInfo);
            }
        }
    }
}