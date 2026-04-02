//HintName: G.JsonConverters.AgentResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class AgentResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AgentResponse>
    {
        /// <inheritdoc />
        public override global::G.AgentResponse Read(
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
            if (__jsonProps.Contains("agent_id")) __score0++;
            if (__jsonProps.Contains("is_published")) __score0++;
            if (__jsonProps.Contains("version")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("agent_name")) __score1++;
            if (__jsonProps.Contains("allow_user_dtmf")) __score1++;
            if (__jsonProps.Contains("ambient_sound")) __score1++;
            if (__jsonProps.Contains("ambient_sound_volume")) __score1++;
            if (__jsonProps.Contains("analysis_successful_prompt")) __score1++;
            if (__jsonProps.Contains("analysis_summary_prompt")) __score1++;
            if (__jsonProps.Contains("analysis_user_sentiment_prompt")) __score1++;
            if (__jsonProps.Contains("backchannel_frequency")) __score1++;
            if (__jsonProps.Contains("backchannel_words")) __score1++;
            if (__jsonProps.Contains("begin_message_delay_ms")) __score1++;
            if (__jsonProps.Contains("boosted_keywords")) __score1++;
            if (__jsonProps.Contains("custom_stt_config")) __score1++;
            if (__jsonProps.Contains("data_storage_retention_days")) __score1++;
            if (__jsonProps.Contains("data_storage_setting")) __score1++;
            if (__jsonProps.Contains("denoising_mode")) __score1++;
            if (__jsonProps.Contains("enable_backchannel")) __score1++;
            if (__jsonProps.Contains("enable_dynamic_responsiveness")) __score1++;
            if (__jsonProps.Contains("enable_dynamic_voice_speed")) __score1++;
            if (__jsonProps.Contains("end_call_after_silence_ms")) __score1++;
            if (__jsonProps.Contains("fallback_voice_ids")) __score1++;
            if (__jsonProps.Contains("guardrail_config")) __score1++;
            if (__jsonProps.Contains("interruption_sensitivity")) __score1++;
            if (__jsonProps.Contains("is_public")) __score1++;
            if (__jsonProps.Contains("ivr_option")) __score1++;
            if (__jsonProps.Contains("language")) __score1++;
            if (__jsonProps.Contains("max_call_duration_ms")) __score1++;
            if (__jsonProps.Contains("normalize_for_speech")) __score1++;
            if (__jsonProps.Contains("opt_in_signed_url")) __score1++;
            if (__jsonProps.Contains("pii_config")) __score1++;
            if (__jsonProps.Contains("post_call_analysis_data")) __score1++;
            if (__jsonProps.Contains("post_call_analysis_model")) __score1++;
            if (__jsonProps.Contains("pronunciation_dictionary")) __score1++;
            if (__jsonProps.Contains("reminder_max_count")) __score1++;
            if (__jsonProps.Contains("reminder_trigger_ms")) __score1++;
            if (__jsonProps.Contains("response_engine")) __score1++;
            if (__jsonProps.Contains("responsiveness")) __score1++;
            if (__jsonProps.Contains("ring_duration_ms")) __score1++;
            if (__jsonProps.Contains("signed_url_expiration_ms")) __score1++;
            if (__jsonProps.Contains("stt_mode")) __score1++;
            if (__jsonProps.Contains("user_dtmf_options")) __score1++;
            if (__jsonProps.Contains("version_description")) __score1++;
            if (__jsonProps.Contains("vocab_specialization")) __score1++;
            if (__jsonProps.Contains("voice_emotion")) __score1++;
            if (__jsonProps.Contains("voice_id")) __score1++;
            if (__jsonProps.Contains("voice_model")) __score1++;
            if (__jsonProps.Contains("voice_speed")) __score1++;
            if (__jsonProps.Contains("voice_temperature")) __score1++;
            if (__jsonProps.Contains("voicemail_detection_timeout_ms")) __score1++;
            if (__jsonProps.Contains("voicemail_message")) __score1++;
            if (__jsonProps.Contains("voicemail_option")) __score1++;
            if (__jsonProps.Contains("volume")) __score1++;
            if (__jsonProps.Contains("webhook_events")) __score1++;
            if (__jsonProps.Contains("webhook_timeout_ms")) __score1++;
            if (__jsonProps.Contains("webhook_url")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("last_modification_timestamp")) __score2++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.AgentResponseVariant1? agentResponseVariant1 = default;
            global::G.AgentRequest? request = default;
            global::G.AgentResponseVariant3? agentResponseVariant3 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentResponseVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentResponseVariant1).Name}");
                        agentResponseVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentRequest).Name}");
                        request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentResponseVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentResponseVariant3).Name}");
                        agentResponseVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (agentResponseVariant1 == null && request == null && agentResponseVariant3 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentResponseVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentResponseVariant1).Name}");
                    agentResponseVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentRequest).Name}");
                    request = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentResponseVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentResponseVariant3).Name}");
                    agentResponseVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.AgentResponse(
                agentResponseVariant1,

                request,

                agentResponseVariant3
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AgentResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAgentResponseVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentResponseVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentResponseVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentResponseVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentResponseVariant1!, typeInfo);
            }
            else if (value.IsRequest)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Request!, typeInfo);
            }
            else if (value.IsAgentResponseVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.AgentResponseVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.AgentResponseVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.AgentResponseVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AgentResponseVariant3!, typeInfo);
            }
        }
    }
}