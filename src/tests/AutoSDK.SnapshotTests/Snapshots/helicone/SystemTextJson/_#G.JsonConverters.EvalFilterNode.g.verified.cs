//HintName: G.JsonConverters.EvalFilterNode.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EvalFilterNodeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EvalFilterNode>
    {
        /// <inheritdoc />
        public override global::G.EvalFilterNode Read(
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
            var __score1 = 0;
            if (__jsonProps.Contains("left")) __score1++;
            if (__jsonProps.Contains("operator")) __score1++;
            if (__jsonProps.Contains("right")) __score1++;
            var __score2 = 0;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }

            global::G.PickFilterLeafRequestResponseRmt? pickLeafRequestResponseRmt = default;
            global::G.EvalFilterBranch? branch = default;
            global::G.EvalFilterNodeEnum? @enum = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PickFilterLeafRequestResponseRmt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PickFilterLeafRequestResponseRmt> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PickFilterLeafRequestResponseRmt).Name}");
                        pickLeafRequestResponseRmt = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EvalFilterBranch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EvalFilterBranch> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EvalFilterBranch).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EvalFilterNodeEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EvalFilterNodeEnum> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EvalFilterNodeEnum).Name}");
                        @enum = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (pickLeafRequestResponseRmt == null && branch == null && @enum == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PickFilterLeafRequestResponseRmt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PickFilterLeafRequestResponseRmt> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PickFilterLeafRequestResponseRmt).Name}");
                    pickLeafRequestResponseRmt = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EvalFilterBranch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EvalFilterBranch> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EvalFilterBranch).Name}");
                    branch = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EvalFilterNodeEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EvalFilterNodeEnum> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EvalFilterNodeEnum).Name}");
                    @enum = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.EvalFilterNode(
                pickLeafRequestResponseRmt,

                branch,

                @enum
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EvalFilterNode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsPickLeafRequestResponseRmt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PickFilterLeafRequestResponseRmt), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PickFilterLeafRequestResponseRmt?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PickFilterLeafRequestResponseRmt).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickLeafRequestResponseRmt!, typeInfo);
            }
            else if (value.IsBranch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EvalFilterBranch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EvalFilterBranch?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EvalFilterBranch).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Branch!, typeInfo);
            }
            else if (value.IsEnum)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EvalFilterNodeEnum), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EvalFilterNodeEnum> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.EvalFilterNodeEnum).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Enum!.Value, typeInfo);
            }
        }
    }
}