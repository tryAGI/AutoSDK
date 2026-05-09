//HintName: G.JsonConverters.FilterNode.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class FilterNodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FilterNode>
    {
        /// <inheritdoc />
        public override global::G.FilterNode Read(
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
            if (__jsonProps.Contains("cache_metrics")) __score0++;
            if (__jsonProps.Contains("cache_metrics.cache_hit_count")) __score0++;
            if (__jsonProps.Contains("cache_metrics.date")) __score0++;
            if (__jsonProps.Contains("cache_metrics.first_hit")) __score0++;
            if (__jsonProps.Contains("cache_metrics.hour")) __score0++;
            if (__jsonProps.Contains("cache_metrics.last_hit")) __score0++;
            if (__jsonProps.Contains("cache_metrics.model")) __score0++;
            if (__jsonProps.Contains("cache_metrics.organization_id")) __score0++;
            if (__jsonProps.Contains("cache_metrics.request_body")) __score0++;
            if (__jsonProps.Contains("cache_metrics.request_id")) __score0++;
            if (__jsonProps.Contains("cache_metrics.response_body")) __score0++;
            if (__jsonProps.Contains("cache_metrics.saved_completion_audio_tokens")) __score0++;
            if (__jsonProps.Contains("cache_metrics.saved_completion_tokens")) __score0++;
            if (__jsonProps.Contains("cache_metrics.saved_latency_ms")) __score0++;
            if (__jsonProps.Contains("cache_metrics.saved_prompt_audio_tokens")) __score0++;
            if (__jsonProps.Contains("cache_metrics.saved_prompt_cache_read_tokens")) __score0++;
            if (__jsonProps.Contains("cache_metrics.saved_prompt_cache_write_tokens")) __score0++;
            if (__jsonProps.Contains("cache_metrics.saved_prompt_tokens")) __score0++;
            if (__jsonProps.Contains("experiment")) __score0++;
            if (__jsonProps.Contains("experiment.id")) __score0++;
            if (__jsonProps.Contains("experiment.prompt_v2")) __score0++;
            if (__jsonProps.Contains("experiment_hypothesis_run")) __score0++;
            if (__jsonProps.Contains("experiment_hypothesis_run.result_request_id")) __score0++;
            if (__jsonProps.Contains("feedback")) __score0++;
            if (__jsonProps.Contains("feedback.created_at")) __score0++;
            if (__jsonProps.Contains("feedback.id")) __score0++;
            if (__jsonProps.Contains("feedback.rating")) __score0++;
            if (__jsonProps.Contains("feedback.response_id")) __score0++;
            if (__jsonProps.Contains("job")) __score0++;
            if (__jsonProps.Contains("job.created_at")) __score0++;
            if (__jsonProps.Contains("job.custom_properties")) __score0++;
            if (__jsonProps.Contains("job.description")) __score0++;
            if (__jsonProps.Contains("job.id")) __score0++;
            if (__jsonProps.Contains("job.name")) __score0++;
            if (__jsonProps.Contains("job.org_id")) __score0++;
            if (__jsonProps.Contains("job.status")) __score0++;
            if (__jsonProps.Contains("job.timeout_seconds")) __score0++;
            if (__jsonProps.Contains("job.updated_at")) __score0++;
            if (__jsonProps.Contains("job_node")) __score0++;
            if (__jsonProps.Contains("job_node.created_at")) __score0++;
            if (__jsonProps.Contains("job_node.custom_properties")) __score0++;
            if (__jsonProps.Contains("job_node.description")) __score0++;
            if (__jsonProps.Contains("job_node.id")) __score0++;
            if (__jsonProps.Contains("job_node.job_id")) __score0++;
            if (__jsonProps.Contains("job_node.name")) __score0++;
            if (__jsonProps.Contains("job_node.org_id")) __score0++;
            if (__jsonProps.Contains("job_node.status")) __score0++;
            if (__jsonProps.Contains("job_node.timeout_seconds")) __score0++;
            if (__jsonProps.Contains("job_node.updated_at")) __score0++;
            if (__jsonProps.Contains("organization_properties")) __score0++;
            if (__jsonProps.Contains("organization_properties.organization_id")) __score0++;
            if (__jsonProps.Contains("organization_properties.property_key")) __score0++;
            if (__jsonProps.Contains("prompt_v2")) __score0++;
            if (__jsonProps.Contains("prompt_v2.id")) __score0++;
            if (__jsonProps.Contains("prompt_v2.user_defined_id")) __score0++;
            if (__jsonProps.Contains("prompts_versions")) __score0++;
            if (__jsonProps.Contains("prompts_versions.id")) __score0++;
            if (__jsonProps.Contains("prompts_versions.major_version")) __score0++;
            if (__jsonProps.Contains("prompts_versions.minor_version")) __score0++;
            if (__jsonProps.Contains("prompts_versions.prompt_v2")) __score0++;
            if (__jsonProps.Contains("properties")) __score0++;
            if (__jsonProps.Contains("properties_table")) __score0++;
            if (__jsonProps.Contains("properties_table.auth_hash")) __score0++;
            if (__jsonProps.Contains("properties_table.key")) __score0++;
            if (__jsonProps.Contains("properties_table.value")) __score0++;
            if (__jsonProps.Contains("properties_v3")) __score0++;
            if (__jsonProps.Contains("properties_v3.key")) __score0++;
            if (__jsonProps.Contains("properties_v3.organization_id")) __score0++;
            if (__jsonProps.Contains("properties_v3.value")) __score0++;
            if (__jsonProps.Contains("property_with_response_v1")) __score0++;
            if (__jsonProps.Contains("property_with_response_v1.organization_id")) __score0++;
            if (__jsonProps.Contains("property_with_response_v1.property_key")) __score0++;
            if (__jsonProps.Contains("property_with_response_v1.property_value")) __score0++;
            if (__jsonProps.Contains("property_with_response_v1.request_created_at")) __score0++;
            if (__jsonProps.Contains("property_with_response_v1.threat")) __score0++;
            if (__jsonProps.Contains("rate_limit_log")) __score0++;
            if (__jsonProps.Contains("rate_limit_log.created_at")) __score0++;
            if (__jsonProps.Contains("rate_limit_log.organization_id")) __score0++;
            if (__jsonProps.Contains("request")) __score0++;
            if (__jsonProps.Contains("request.auth_hash")) __score0++;
            if (__jsonProps.Contains("request.country_code")) __score0++;
            if (__jsonProps.Contains("request.created_at")) __score0++;
            if (__jsonProps.Contains("request.id")) __score0++;
            if (__jsonProps.Contains("request.model")) __score0++;
            if (__jsonProps.Contains("request.modelOverride")) __score0++;
            if (__jsonProps.Contains("request.node_id")) __score0++;
            if (__jsonProps.Contains("request.org_id")) __score0++;
            if (__jsonProps.Contains("request.path")) __score0++;
            if (__jsonProps.Contains("request.prompt")) __score0++;
            if (__jsonProps.Contains("request.prompt_id")) __score0++;
            if (__jsonProps.Contains("request.user_id")) __score0++;
            if (__jsonProps.Contains("request_response_log")) __score0++;
            if (__jsonProps.Contains("request_response_log.auth_hash")) __score0++;
            if (__jsonProps.Contains("request_response_log.job_id")) __score0++;
            if (__jsonProps.Contains("request_response_log.latency")) __score0++;
            if (__jsonProps.Contains("request_response_log.model")) __score0++;
            if (__jsonProps.Contains("request_response_log.node_id")) __score0++;
            if (__jsonProps.Contains("request_response_log.organization_id")) __score0++;
            if (__jsonProps.Contains("request_response_log.request_created_at")) __score0++;
            if (__jsonProps.Contains("request_response_log.response_created_at")) __score0++;
            if (__jsonProps.Contains("request_response_log.status")) __score0++;
            if (__jsonProps.Contains("request_response_log.threat")) __score0++;
            if (__jsonProps.Contains("request_response_log.user_id")) __score0++;
            if (__jsonProps.Contains("request_response_rmt")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.assets")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.cache_enabled")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.cache_reference_id")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.cached")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.completion_tokens")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.cost")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.country_code")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.helicone-score-feedback")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.is_passthrough_billing")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.job_id")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.latency")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.model")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.node_id")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.organization_id")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.prompt_cache_read_tokens")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.prompt_cache_write_tokens")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.prompt_id")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.prompt_tokens")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.prompt_version")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.properties")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.property_key")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.provider")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.request_body")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.request_created_at")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.request_id")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.request_referrer")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.response_body")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.response_created_at")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.scores")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.scores_column")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.search_properties")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.status")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.target_url")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.threat")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.time_to_first_token")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.total_tokens")) __score0++;
            if (__jsonProps.Contains("request_response_rmt.user_id")) __score0++;
            if (__jsonProps.Contains("response")) __score0++;
            if (__jsonProps.Contains("response.body_completion")) __score0++;
            if (__jsonProps.Contains("response.body_model")) __score0++;
            if (__jsonProps.Contains("response.body_tokens")) __score0++;
            if (__jsonProps.Contains("response.model")) __score0++;
            if (__jsonProps.Contains("response.status")) __score0++;
            if (__jsonProps.Contains("score_value")) __score0++;
            if (__jsonProps.Contains("score_value.request_id")) __score0++;
            if (__jsonProps.Contains("sessions_request_response_rmt")) __score0++;
            if (__jsonProps.Contains("sessions_request_response_rmt.session_completion_tokens")) __score0++;
            if (__jsonProps.Contains("sessions_request_response_rmt.session_created_at")) __score0++;
            if (__jsonProps.Contains("sessions_request_response_rmt.session_latest_request_created_at")) __score0++;
            if (__jsonProps.Contains("sessions_request_response_rmt.session_prompt_tokens")) __score0++;
            if (__jsonProps.Contains("sessions_request_response_rmt.session_session_id")) __score0++;
            if (__jsonProps.Contains("sessions_request_response_rmt.session_session_name")) __score0++;
            if (__jsonProps.Contains("sessions_request_response_rmt.session_tag")) __score0++;
            if (__jsonProps.Contains("sessions_request_response_rmt.session_total_cost")) __score0++;
            if (__jsonProps.Contains("sessions_request_response_rmt.session_total_requests")) __score0++;
            if (__jsonProps.Contains("sessions_request_response_rmt.session_total_tokens")) __score0++;
            if (__jsonProps.Contains("user_api_keys")) __score0++;
            if (__jsonProps.Contains("user_api_keys.api_key_hash")) __score0++;
            if (__jsonProps.Contains("user_api_keys.api_key_name")) __score0++;
            if (__jsonProps.Contains("user_metrics")) __score0++;
            if (__jsonProps.Contains("user_metrics.active_for")) __score0++;
            if (__jsonProps.Contains("user_metrics.average_requests_per_day_active")) __score0++;
            if (__jsonProps.Contains("user_metrics.average_tokens_per_request")) __score0++;
            if (__jsonProps.Contains("user_metrics.cost")) __score0++;
            if (__jsonProps.Contains("user_metrics.last_active")) __score0++;
            if (__jsonProps.Contains("user_metrics.total_completion_tokens")) __score0++;
            if (__jsonProps.Contains("user_metrics.total_prompt_tokens")) __score0++;
            if (__jsonProps.Contains("user_metrics.total_requests")) __score0++;
            if (__jsonProps.Contains("user_metrics.user_id")) __score0++;
            if (__jsonProps.Contains("users_view")) __score0++;
            if (__jsonProps.Contains("users_view.user_active_for")) __score0++;
            if (__jsonProps.Contains("users_view.user_average_requests_per_day_active")) __score0++;
            if (__jsonProps.Contains("users_view.user_average_tokens_per_request")) __score0++;
            if (__jsonProps.Contains("users_view.user_cost")) __score0++;
            if (__jsonProps.Contains("users_view.user_first_active")) __score0++;
            if (__jsonProps.Contains("users_view.user_last_active")) __score0++;
            if (__jsonProps.Contains("users_view.user_total_completion_tokens")) __score0++;
            if (__jsonProps.Contains("users_view.user_total_prompt_tokens")) __score0++;
            if (__jsonProps.Contains("users_view.user_total_requests")) __score0++;
            if (__jsonProps.Contains("users_view.user_user_id")) __score0++;
            if (__jsonProps.Contains("values")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("left")) __score1++;
            if (__jsonProps.Contains("operator")) __score1++;
            if (__jsonProps.Contains("right")) __score1++;
            var __score2 = 0;
            var __score3 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }

            global::G.PartialTablesAndViews? partialTablesAndViews = default;
            global::G.FilterBranch? branch = default;
            object? @enum = default;
            global::G.FilterNodeEnum2? enum2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PartialTablesAndViews), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PartialTablesAndViews> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PartialTablesAndViews).Name}");
                        partialTablesAndViews = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FilterBranch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FilterBranch> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FilterBranch).Name}");
                        branch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                        @enum = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 3)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FilterNodeEnum2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FilterNodeEnum2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FilterNodeEnum2).Name}");
                        enum2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (partialTablesAndViews == null && branch == null && @enum == null && enum2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PartialTablesAndViews), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PartialTablesAndViews> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PartialTablesAndViews).Name}");
                    partialTablesAndViews = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (partialTablesAndViews == null && branch == null && @enum == null && enum2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FilterBranch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FilterBranch> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FilterBranch).Name}");
                    branch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (partialTablesAndViews == null && branch == null && @enum == null && enum2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    @enum = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (partialTablesAndViews == null && branch == null && @enum == null && enum2 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FilterNodeEnum2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FilterNodeEnum2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FilterNodeEnum2).Name}");
                    enum2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.FilterNode(
                partialTablesAndViews,

                branch,

                @enum,

                enum2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FilterNode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPartialTablesAndViews)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PartialTablesAndViews), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PartialTablesAndViews?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PartialTablesAndViews).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PartialTablesAndViews!, typeInfo);
            }
            else if (value.IsBranch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FilterBranch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FilterBranch?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FilterBranch).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Branch!, typeInfo);
            }
            else if (value.IsEnum)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enum!, typeInfo);
            }
            else if (value.IsEnum2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FilterNodeEnum2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FilterNodeEnum2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FilterNodeEnum2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enum2!.Value, typeInfo);
            }
        }
    }
}