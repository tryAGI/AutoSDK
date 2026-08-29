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

            global::G.NodeBaseCommon? baseCommon = default;
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

            global::G.ComponentNodeVariant2? componentNodeVariant2 = default;
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


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsBaseCommon)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NodeBaseCommon), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NodeBaseCommon?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NodeBaseCommon).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.BaseCommon!, typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsComponentNodeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ComponentNodeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ComponentNodeVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ComponentNodeVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.ComponentNodeVariant2!, typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}