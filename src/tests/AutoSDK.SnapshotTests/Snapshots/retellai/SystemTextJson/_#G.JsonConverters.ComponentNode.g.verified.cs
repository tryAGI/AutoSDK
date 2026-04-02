//HintName: G.JsonConverters.ComponentNode.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ComponentNodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ComponentNode>
    {
        /// <inheritdoc />
        public override global::G.ComponentNode Read(
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
            if (__jsonProps.Contains("display_position")) __score0++;
            if (__jsonProps.Contains("global_node_setting")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("component_id")) __score1++;
            if (__jsonProps.Contains("component_type")) __score1++;
            if (__jsonProps.Contains("edges")) __score1++;
            if (__jsonProps.Contains("else_edge")) __score1++;
            if (__jsonProps.Contains("finetune_transition_examples")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.NodeBaseCommon? baseCommon = default;
            global::G.ComponentNodeVariant2? componentNodeVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NodeBaseCommon), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NodeBaseCommon> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NodeBaseCommon).Name}");
                        baseCommon = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComponentNodeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComponentNodeVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComponentNodeVariant2).Name}");
                        componentNodeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (baseCommon == null && componentNodeVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NodeBaseCommon), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NodeBaseCommon> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NodeBaseCommon).Name}");
                    baseCommon = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComponentNodeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComponentNodeVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComponentNodeVariant2).Name}");
                    componentNodeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ComponentNode(
                baseCommon,

                componentNodeVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ComponentNode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsBaseCommon)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NodeBaseCommon), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NodeBaseCommon?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NodeBaseCommon).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BaseCommon!, typeInfo);
            }
            else if (value.IsComponentNodeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComponentNodeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComponentNodeVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComponentNodeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ComponentNodeVariant2!, typeInfo);
            }
        }
    }
}