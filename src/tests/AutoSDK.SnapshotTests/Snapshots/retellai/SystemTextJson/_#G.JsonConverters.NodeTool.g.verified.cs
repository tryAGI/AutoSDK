//HintName: G.JsonConverters.NodeTool.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class NodeToolJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.NodeTool>
    {
        /// <inheritdoc />
        public override global::G.NodeTool Read(
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
            if (__jsonProps.Contains("tool_id")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>? nodeToolVariant1 = default;
            global::G.NodeToolVariant2? nodeToolVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>).Name}");
                        nodeToolVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NodeToolVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NodeToolVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NodeToolVariant2).Name}");
                        nodeToolVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (nodeToolVariant1 == null && nodeToolVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>).Name}");
                    nodeToolVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NodeToolVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NodeToolVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NodeToolVariant2).Name}");
                    nodeToolVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.NodeTool(
                nodeToolVariant1,

                nodeToolVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.NodeTool value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsNodeToolVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OneOf<global::G.CustomTool, global::G.CheckAvailabilityCalTool, global::G.BookAppointmentCalTool>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeToolVariant1!.Value, typeInfo);
            }
            else if (value.IsNodeToolVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.NodeToolVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.NodeToolVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.NodeToolVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NodeToolVariant2!, typeInfo);
            }
        }
    }
}