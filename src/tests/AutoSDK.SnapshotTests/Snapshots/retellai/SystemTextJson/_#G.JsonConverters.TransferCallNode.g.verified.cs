//HintName: G.JsonConverters.TransferCallNode.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TransferCallNodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TransferCallNode>
    {
        /// <inheritdoc />
        public override global::G.TransferCallNode Read(
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
            if (__jsonProps.Contains("custom_sip_headers")) __score1++;
            if (__jsonProps.Contains("edge")) __score1++;
            if (__jsonProps.Contains("ignore_e164_validation")) __score1++;
            if (__jsonProps.Contains("instruction")) __score1++;
            if (__jsonProps.Contains("speak_during_execution")) __score1++;
            if (__jsonProps.Contains("transfer_destination")) __score1++;
            if (__jsonProps.Contains("transfer_option")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.NodeBase? @base = default;
            global::G.TransferCallNodeVariant2? transferCallNodeVariant2 = default;
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferCallNodeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferCallNodeVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferCallNodeVariant2).Name}");
                        transferCallNodeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (@base == null && transferCallNodeVariant2 == null)
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferCallNodeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferCallNodeVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferCallNodeVariant2).Name}");
                    transferCallNodeVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.TransferCallNode(
                @base,

                transferCallNodeVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TransferCallNode value,
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
            else if (value.IsTransferCallNodeVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferCallNodeVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferCallNodeVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferCallNodeVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TransferCallNodeVariant2!, typeInfo);
            }
        }
    }
}