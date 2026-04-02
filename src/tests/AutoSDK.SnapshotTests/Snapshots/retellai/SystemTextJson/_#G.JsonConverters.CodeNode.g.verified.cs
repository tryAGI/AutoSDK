//HintName: G.JsonConverters.CodeNode.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class CodeNodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CodeNode>
    {
        /// <inheritdoc />
        public override global::G.CodeNode Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("code")) __score1++;
            if (__jsonProps.Contains("edges")) __score1++;
            if (__jsonProps.Contains("else_edge")) __score1++;
            if (__jsonProps.Contains("finetune_transition_examples")) __score1++;
            if (__jsonProps.Contains("instruction")) __score1++;
            if (__jsonProps.Contains("response_variables")) __score1++;
            if (__jsonProps.Contains("speak_during_execution")) __score1++;
            if (__jsonProps.Contains("timeout_ms")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            if (__jsonProps.Contains("wait_for_result")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.NodeBase? @base = default;
            global::G.CodeNodeVariant2? codeNodeVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NodeBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NodeBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NodeBase).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeNodeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeNodeVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeNodeVariant2).Name}");
                        codeNodeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && codeNodeVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NodeBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NodeBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NodeBase).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeNodeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeNodeVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeNodeVariant2).Name}");
                    codeNodeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.CodeNode(
                @base,

                codeNodeVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CodeNode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBase)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NodeBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NodeBase> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NodeBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Base!.Value, typeInfo);
            }
            else if (value.IsCodeNodeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeNodeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeNodeVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeNodeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.CodeNodeVariant2!, typeInfo);
            }
        }
    }
}