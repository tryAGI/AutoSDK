//HintName: G.JsonConverters.ResultHeliconeRequestString.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ResultHeliconeRequestStringJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ResultHeliconeRequestString>
    {
        /// <inheritdoc />
        public override global::G.ResultHeliconeRequestString Read(
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
                    if (__jsonProp.Value.ValueKind == global::System.Text.Json.JsonValueKind.Object)
                    {
                        foreach (var __nestedJsonProp in __jsonProp.Value.EnumerateObject())
                        {
                            __jsonProps.Add(__jsonProp.Name + "." + __nestedJsonProp.Name);
                        }
                    }

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("data")) __score0++;
            if (__jsonProps.Contains("data.ai_gateway_body_mapping")) __score0++;
            if (__jsonProps.Contains("data.asset_ids")) __score0++;
            if (__jsonProps.Contains("data.asset_urls")) __score0++;
            if (__jsonProps.Contains("data.assets")) __score0++;
            if (__jsonProps.Contains("data.cache_enabled")) __score0++;
            if (__jsonProps.Contains("data.cache_reference_id")) __score0++;
            if (__jsonProps.Contains("data.completion_audio_tokens")) __score0++;
            if (__jsonProps.Contains("data.completion_tokens")) __score0++;
            if (__jsonProps.Contains("data.cost")) __score0++;
            if (__jsonProps.Contains("data.costUSD")) __score0++;
            if (__jsonProps.Contains("data.country_code")) __score0++;
            if (__jsonProps.Contains("data.delay_ms")) __score0++;
            if (__jsonProps.Contains("data.feedback_created_at")) __score0++;
            if (__jsonProps.Contains("data.feedback_id")) __score0++;
            if (__jsonProps.Contains("data.feedback_rating")) __score0++;
            if (__jsonProps.Contains("data.helicone_user")) __score0++;
            if (__jsonProps.Contains("data.llmSchema")) __score0++;
            if (__jsonProps.Contains("data.model")) __score0++;
            if (__jsonProps.Contains("data.model_override")) __score0++;
            if (__jsonProps.Contains("data.prompt_audio_tokens")) __score0++;
            if (__jsonProps.Contains("data.prompt_cache_read_tokens")) __score0++;
            if (__jsonProps.Contains("data.prompt_cache_write_tokens")) __score0++;
            if (__jsonProps.Contains("data.prompt_id")) __score0++;
            if (__jsonProps.Contains("data.prompt_tokens")) __score0++;
            if (__jsonProps.Contains("data.prompt_version")) __score0++;
            if (__jsonProps.Contains("data.properties")) __score0++;
            if (__jsonProps.Contains("data.provider")) __score0++;
            if (__jsonProps.Contains("data.reasoning_tokens")) __score0++;
            if (__jsonProps.Contains("data.request_body")) __score0++;
            if (__jsonProps.Contains("data.request_created_at")) __score0++;
            if (__jsonProps.Contains("data.request_id")) __score0++;
            if (__jsonProps.Contains("data.request_model")) __score0++;
            if (__jsonProps.Contains("data.request_path")) __score0++;
            if (__jsonProps.Contains("data.request_properties")) __score0++;
            if (__jsonProps.Contains("data.request_referrer")) __score0++;
            if (__jsonProps.Contains("data.request_user_id")) __score0++;
            if (__jsonProps.Contains("data.response_body")) __score0++;
            if (__jsonProps.Contains("data.response_created_at")) __score0++;
            if (__jsonProps.Contains("data.response_id")) __score0++;
            if (__jsonProps.Contains("data.response_model")) __score0++;
            if (__jsonProps.Contains("data.response_status")) __score0++;
            if (__jsonProps.Contains("data.scores")) __score0++;
            if (__jsonProps.Contains("data.signed_body_url")) __score0++;
            if (__jsonProps.Contains("data.storage_location")) __score0++;
            if (__jsonProps.Contains("data.target_url")) __score0++;
            if (__jsonProps.Contains("data.time_to_first_token")) __score0++;
            if (__jsonProps.Contains("data.total_tokens")) __score0++;
            if (__jsonProps.Contains("data.updated_at")) __score0++;
            if (__jsonProps.Contains("error")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("error")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.ResultSuccessHeliconeRequest? success = default;
            global::G.ResultErrorString? error = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResultSuccessHeliconeRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResultSuccessHeliconeRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResultSuccessHeliconeRequest).Name}");
                        success = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResultErrorString), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResultErrorString> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResultErrorString).Name}");
                        error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (success == null && error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResultSuccessHeliconeRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResultSuccessHeliconeRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResultSuccessHeliconeRequest).Name}");
                    success = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (success == null && error == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResultErrorString), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResultErrorString> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResultErrorString).Name}");
                    error = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.ResultHeliconeRequestString(
                success,

                error
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ResultHeliconeRequestString value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResultSuccessHeliconeRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResultSuccessHeliconeRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResultSuccessHeliconeRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success!, typeInfo);
            }
            else if (value.IsError)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ResultErrorString), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ResultErrorString?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ResultErrorString).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Error!, typeInfo);
            }
        }
    }
}