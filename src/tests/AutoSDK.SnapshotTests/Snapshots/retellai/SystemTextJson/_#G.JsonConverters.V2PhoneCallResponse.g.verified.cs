//HintName: G.JsonConverters.V2PhoneCallResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class V2PhoneCallResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.V2PhoneCallResponse>
    {
        /// <inheritdoc />
        public override global::G.V2PhoneCallResponse Read(
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
            if (__jsonProps.Contains("call_type")) __score0++;
            if (__jsonProps.Contains("direction")) __score0++;
            if (__jsonProps.Contains("from_number")) __score0++;
            if (__jsonProps.Contains("telephony_identifier")) __score0++;
            if (__jsonProps.Contains("to_number")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("agent_id")) __score1++;
            if (__jsonProps.Contains("agent_name")) __score1++;
            if (__jsonProps.Contains("agent_version")) __score1++;
            if (__jsonProps.Contains("call_analysis")) __score1++;
            if (__jsonProps.Contains("call_cost")) __score1++;
            if (__jsonProps.Contains("call_id")) __score1++;
            if (__jsonProps.Contains("call_status")) __score1++;
            if (__jsonProps.Contains("collected_dynamic_variables")) __score1++;
            if (__jsonProps.Contains("custom_sip_headers")) __score1++;
            if (__jsonProps.Contains("data_storage_setting")) __score1++;
            if (__jsonProps.Contains("disconnection_reason")) __score1++;
            if (__jsonProps.Contains("duration_ms")) __score1++;
            if (__jsonProps.Contains("end_timestamp")) __score1++;
            if (__jsonProps.Contains("knowledge_base_retrieved_contents_url")) __score1++;
            if (__jsonProps.Contains("latency")) __score1++;
            if (__jsonProps.Contains("llm_token_usage")) __score1++;
            if (__jsonProps.Contains("metadata")) __score1++;
            if (__jsonProps.Contains("opt_in_signed_url")) __score1++;
            if (__jsonProps.Contains("public_log_url")) __score1++;
            if (__jsonProps.Contains("recording_multi_channel_url")) __score1++;
            if (__jsonProps.Contains("recording_url")) __score1++;
            if (__jsonProps.Contains("retell_llm_dynamic_variables")) __score1++;
            if (__jsonProps.Contains("scrubbed_recording_multi_channel_url")) __score1++;
            if (__jsonProps.Contains("scrubbed_recording_url")) __score1++;
            if (__jsonProps.Contains("scrubbed_transcript_with_tool_calls")) __score1++;
            if (__jsonProps.Contains("start_timestamp")) __score1++;
            if (__jsonProps.Contains("transcript")) __score1++;
            if (__jsonProps.Contains("transcript_object")) __score1++;
            if (__jsonProps.Contains("transcript_with_tool_calls")) __score1++;
            if (__jsonProps.Contains("transfer_destination")) __score1++;
            if (__jsonProps.Contains("transfer_end_timestamp")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.V2PhoneCallResponseVariant1? value1 = default;
            global::G.V2CallBase? value2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.V2PhoneCallResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.V2PhoneCallResponseVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.V2PhoneCallResponseVariant1).Name}");
                        value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.V2CallBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.V2CallBase> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.V2CallBase).Name}");
                        value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && value2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.V2PhoneCallResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.V2PhoneCallResponseVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.V2PhoneCallResponseVariant1).Name}");
                    value1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.V2CallBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.V2CallBase> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.V2CallBase).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.V2PhoneCallResponse(
                value1,

                value2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.V2PhoneCallResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.V2PhoneCallResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.V2PhoneCallResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.V2PhoneCallResponseVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.V2CallBase), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.V2CallBase?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.V2CallBase).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}