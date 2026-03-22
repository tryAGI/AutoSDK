//HintName: G.JsonConverters.TranscriptParams.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class TranscriptParamsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TranscriptParams>
    {
        /// <inheritdoc />
        public override global::G.TranscriptParams Read(
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
            if (__jsonProps.Contains("audio_url")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("audio_end_at")) __score1++;
            if (__jsonProps.Contains("audio_start_from")) __score1++;
            if (__jsonProps.Contains("auto_chapters")) __score1++;
            if (__jsonProps.Contains("auto_highlights")) __score1++;
            if (__jsonProps.Contains("boost_param")) __score1++;
            if (__jsonProps.Contains("content_safety")) __score1++;
            if (__jsonProps.Contains("content_safety_confidence")) __score1++;
            if (__jsonProps.Contains("custom_spelling")) __score1++;
            if (__jsonProps.Contains("custom_topics")) __score1++;
            if (__jsonProps.Contains("disfluencies")) __score1++;
            if (__jsonProps.Contains("dual_channel")) __score1++;
            if (__jsonProps.Contains("entity_detection")) __score1++;
            if (__jsonProps.Contains("filter_profanity")) __score1++;
            if (__jsonProps.Contains("format_text")) __score1++;
            if (__jsonProps.Contains("iab_categories")) __score1++;
            if (__jsonProps.Contains("language_code")) __score1++;
            if (__jsonProps.Contains("language_confidence_threshold")) __score1++;
            if (__jsonProps.Contains("language_detection")) __score1++;
            if (__jsonProps.Contains("punctuate")) __score1++;
            if (__jsonProps.Contains("redact_pii")) __score1++;
            if (__jsonProps.Contains("redact_pii_audio")) __score1++;
            if (__jsonProps.Contains("redact_pii_audio_quality")) __score1++;
            if (__jsonProps.Contains("redact_pii_policies")) __score1++;
            if (__jsonProps.Contains("redact_pii_sub")) __score1++;
            if (__jsonProps.Contains("sentiment_analysis")) __score1++;
            if (__jsonProps.Contains("speaker_labels")) __score1++;
            if (__jsonProps.Contains("speakers_expected")) __score1++;
            if (__jsonProps.Contains("speech_model")) __score1++;
            if (__jsonProps.Contains("speech_threshold")) __score1++;
            if (__jsonProps.Contains("summarization")) __score1++;
            if (__jsonProps.Contains("summary_model")) __score1++;
            if (__jsonProps.Contains("summary_type")) __score1++;
            if (__jsonProps.Contains("topics")) __score1++;
            if (__jsonProps.Contains("webhook_auth_header_name")) __score1++;
            if (__jsonProps.Contains("webhook_auth_header_value")) __score1++;
            if (__jsonProps.Contains("webhook_url")) __score1++;
            if (__jsonProps.Contains("word_boost")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.TranscriptParamsVariant1? value1 = default;
            global::G.TranscriptOptionalParams? value2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptParamsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptParamsVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TranscriptParamsVariant1).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptOptionalParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptOptionalParams> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TranscriptOptionalParams).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptParamsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptParamsVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TranscriptParamsVariant1).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptOptionalParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptOptionalParams> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TranscriptOptionalParams).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.TranscriptParams(
                value1,

                value2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TranscriptParams value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptParamsVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptParamsVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TranscriptParamsVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TranscriptOptionalParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TranscriptOptionalParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TranscriptOptionalParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}