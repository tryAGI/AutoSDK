//HintName: G.JsonConverters.TransferOption.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TransferOptionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TransferOption>
    {
        /// <inheritdoc />
        public override global::G.TransferOption Read(
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
            if (__jsonProps.Contains("cold_transfer_mode")) __score0++;
            if (__jsonProps.Contains("show_transferee_as_caller")) __score0++;
            if (__jsonProps.Contains("transfer_ring_duration_ms")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("agent_detection_timeout_ms")) __score1++;
            if (__jsonProps.Contains("enable_bridge_audio_cue")) __score1++;
            if (__jsonProps.Contains("ivr_option")) __score1++;
            if (__jsonProps.Contains("on_hold_music")) __score1++;
            if (__jsonProps.Contains("opt_out_human_detection")) __score1++;
            if (__jsonProps.Contains("private_handoff_option")) __score1++;
            if (__jsonProps.Contains("public_handoff_option")) __score1++;
            if (__jsonProps.Contains("show_transferee_as_caller")) __score1++;
            if (__jsonProps.Contains("transfer_ring_duration_ms")) __score1++;
            if (__jsonProps.Contains("type")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("agentic_transfer_config")) __score2++;
            if (__jsonProps.Contains("enable_bridge_audio_cue")) __score2++;
            if (__jsonProps.Contains("on_hold_music")) __score2++;
            if (__jsonProps.Contains("public_handoff_option")) __score2++;
            if (__jsonProps.Contains("show_transferee_as_caller")) __score2++;
            if (__jsonProps.Contains("transfer_ring_duration_ms")) __score2++;
            if (__jsonProps.Contains("type")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.TransferOptionColdTransfer? coldTransfer = default;
            global::G.TransferOptionWarmTransfer? warmTransfer = default;
            global::G.TransferOptionAgenticWarmTransfer? agenticWarmTransfer = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferOptionColdTransfer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferOptionColdTransfer> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferOptionColdTransfer).Name}");
                        coldTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferOptionWarmTransfer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferOptionWarmTransfer> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferOptionWarmTransfer).Name}");
                        warmTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferOptionAgenticWarmTransfer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferOptionAgenticWarmTransfer> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferOptionAgenticWarmTransfer).Name}");
                        agenticWarmTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (coldTransfer == null && warmTransfer == null && agenticWarmTransfer == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferOptionColdTransfer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferOptionColdTransfer> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferOptionColdTransfer).Name}");
                    coldTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferOptionWarmTransfer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferOptionWarmTransfer> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferOptionWarmTransfer).Name}");
                    warmTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferOptionAgenticWarmTransfer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferOptionAgenticWarmTransfer> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferOptionAgenticWarmTransfer).Name}");
                    agenticWarmTransfer = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.TransferOption(
                coldTransfer,

                warmTransfer,

                agenticWarmTransfer
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TransferOption value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsColdTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferOptionColdTransfer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferOptionColdTransfer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferOptionColdTransfer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ColdTransfer!, typeInfo);
            }
            else if (value.IsWarmTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferOptionWarmTransfer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferOptionWarmTransfer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferOptionWarmTransfer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WarmTransfer!, typeInfo);
            }
            else if (value.IsAgenticWarmTransfer)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TransferOptionAgenticWarmTransfer), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TransferOptionAgenticWarmTransfer?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TransferOptionAgenticWarmTransfer).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgenticWarmTransfer!, typeInfo);
            }
        }
    }
}