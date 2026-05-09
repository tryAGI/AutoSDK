//HintName: G.JsonConverters.RunStreamEvent.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RunStreamEventJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RunStreamEvent>
    {
        /// <inheritdoc />
        public override global::G.RunStreamEvent Read(
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
            if (__jsonProps.Contains("data.assistant_id")) __score0++;
            if (__jsonProps.Contains("data.cancelled_at")) __score0++;
            if (__jsonProps.Contains("data.completed_at")) __score0++;
            if (__jsonProps.Contains("data.created_at")) __score0++;
            if (__jsonProps.Contains("data.expires_at")) __score0++;
            if (__jsonProps.Contains("data.failed_at")) __score0++;
            if (__jsonProps.Contains("data.id")) __score0++;
            if (__jsonProps.Contains("data.incomplete_details")) __score0++;
            if (__jsonProps.Contains("data.instructions")) __score0++;
            if (__jsonProps.Contains("data.last_error")) __score0++;
            if (__jsonProps.Contains("data.max_completion_tokens")) __score0++;
            if (__jsonProps.Contains("data.max_prompt_tokens")) __score0++;
            if (__jsonProps.Contains("data.metadata")) __score0++;
            if (__jsonProps.Contains("data.model")) __score0++;
            if (__jsonProps.Contains("data.object")) __score0++;
            if (__jsonProps.Contains("data.parallel_tool_calls")) __score0++;
            if (__jsonProps.Contains("data.required_action")) __score0++;
            if (__jsonProps.Contains("data.response_format")) __score0++;
            if (__jsonProps.Contains("data.started_at")) __score0++;
            if (__jsonProps.Contains("data.status")) __score0++;
            if (__jsonProps.Contains("data.temperature")) __score0++;
            if (__jsonProps.Contains("data.thread_id")) __score0++;
            if (__jsonProps.Contains("data.tool_choice")) __score0++;
            if (__jsonProps.Contains("data.tools")) __score0++;
            if (__jsonProps.Contains("data.top_p")) __score0++;
            if (__jsonProps.Contains("data.truncation_strategy")) __score0++;
            if (__jsonProps.Contains("data.usage")) __score0++;
            if (__jsonProps.Contains("event")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("data")) __score1++;
            if (__jsonProps.Contains("data.assistant_id")) __score1++;
            if (__jsonProps.Contains("data.cancelled_at")) __score1++;
            if (__jsonProps.Contains("data.completed_at")) __score1++;
            if (__jsonProps.Contains("data.created_at")) __score1++;
            if (__jsonProps.Contains("data.expires_at")) __score1++;
            if (__jsonProps.Contains("data.failed_at")) __score1++;
            if (__jsonProps.Contains("data.id")) __score1++;
            if (__jsonProps.Contains("data.incomplete_details")) __score1++;
            if (__jsonProps.Contains("data.instructions")) __score1++;
            if (__jsonProps.Contains("data.last_error")) __score1++;
            if (__jsonProps.Contains("data.max_completion_tokens")) __score1++;
            if (__jsonProps.Contains("data.max_prompt_tokens")) __score1++;
            if (__jsonProps.Contains("data.metadata")) __score1++;
            if (__jsonProps.Contains("data.model")) __score1++;
            if (__jsonProps.Contains("data.object")) __score1++;
            if (__jsonProps.Contains("data.parallel_tool_calls")) __score1++;
            if (__jsonProps.Contains("data.required_action")) __score1++;
            if (__jsonProps.Contains("data.response_format")) __score1++;
            if (__jsonProps.Contains("data.started_at")) __score1++;
            if (__jsonProps.Contains("data.status")) __score1++;
            if (__jsonProps.Contains("data.temperature")) __score1++;
            if (__jsonProps.Contains("data.thread_id")) __score1++;
            if (__jsonProps.Contains("data.tool_choice")) __score1++;
            if (__jsonProps.Contains("data.tools")) __score1++;
            if (__jsonProps.Contains("data.top_p")) __score1++;
            if (__jsonProps.Contains("data.truncation_strategy")) __score1++;
            if (__jsonProps.Contains("data.usage")) __score1++;
            if (__jsonProps.Contains("event")) __score1++;
            var __score2 = 0;
            if (__jsonProps.Contains("data")) __score2++;
            if (__jsonProps.Contains("data.assistant_id")) __score2++;
            if (__jsonProps.Contains("data.cancelled_at")) __score2++;
            if (__jsonProps.Contains("data.completed_at")) __score2++;
            if (__jsonProps.Contains("data.created_at")) __score2++;
            if (__jsonProps.Contains("data.expires_at")) __score2++;
            if (__jsonProps.Contains("data.failed_at")) __score2++;
            if (__jsonProps.Contains("data.id")) __score2++;
            if (__jsonProps.Contains("data.incomplete_details")) __score2++;
            if (__jsonProps.Contains("data.instructions")) __score2++;
            if (__jsonProps.Contains("data.last_error")) __score2++;
            if (__jsonProps.Contains("data.max_completion_tokens")) __score2++;
            if (__jsonProps.Contains("data.max_prompt_tokens")) __score2++;
            if (__jsonProps.Contains("data.metadata")) __score2++;
            if (__jsonProps.Contains("data.model")) __score2++;
            if (__jsonProps.Contains("data.object")) __score2++;
            if (__jsonProps.Contains("data.parallel_tool_calls")) __score2++;
            if (__jsonProps.Contains("data.required_action")) __score2++;
            if (__jsonProps.Contains("data.response_format")) __score2++;
            if (__jsonProps.Contains("data.started_at")) __score2++;
            if (__jsonProps.Contains("data.status")) __score2++;
            if (__jsonProps.Contains("data.temperature")) __score2++;
            if (__jsonProps.Contains("data.thread_id")) __score2++;
            if (__jsonProps.Contains("data.tool_choice")) __score2++;
            if (__jsonProps.Contains("data.tools")) __score2++;
            if (__jsonProps.Contains("data.top_p")) __score2++;
            if (__jsonProps.Contains("data.truncation_strategy")) __score2++;
            if (__jsonProps.Contains("data.usage")) __score2++;
            if (__jsonProps.Contains("event")) __score2++;
            var __score3 = 0;
            if (__jsonProps.Contains("data")) __score3++;
            if (__jsonProps.Contains("data.assistant_id")) __score3++;
            if (__jsonProps.Contains("data.cancelled_at")) __score3++;
            if (__jsonProps.Contains("data.completed_at")) __score3++;
            if (__jsonProps.Contains("data.created_at")) __score3++;
            if (__jsonProps.Contains("data.expires_at")) __score3++;
            if (__jsonProps.Contains("data.failed_at")) __score3++;
            if (__jsonProps.Contains("data.id")) __score3++;
            if (__jsonProps.Contains("data.incomplete_details")) __score3++;
            if (__jsonProps.Contains("data.instructions")) __score3++;
            if (__jsonProps.Contains("data.last_error")) __score3++;
            if (__jsonProps.Contains("data.max_completion_tokens")) __score3++;
            if (__jsonProps.Contains("data.max_prompt_tokens")) __score3++;
            if (__jsonProps.Contains("data.metadata")) __score3++;
            if (__jsonProps.Contains("data.model")) __score3++;
            if (__jsonProps.Contains("data.object")) __score3++;
            if (__jsonProps.Contains("data.parallel_tool_calls")) __score3++;
            if (__jsonProps.Contains("data.required_action")) __score3++;
            if (__jsonProps.Contains("data.response_format")) __score3++;
            if (__jsonProps.Contains("data.started_at")) __score3++;
            if (__jsonProps.Contains("data.status")) __score3++;
            if (__jsonProps.Contains("data.temperature")) __score3++;
            if (__jsonProps.Contains("data.thread_id")) __score3++;
            if (__jsonProps.Contains("data.tool_choice")) __score3++;
            if (__jsonProps.Contains("data.tools")) __score3++;
            if (__jsonProps.Contains("data.top_p")) __score3++;
            if (__jsonProps.Contains("data.truncation_strategy")) __score3++;
            if (__jsonProps.Contains("data.usage")) __score3++;
            if (__jsonProps.Contains("event")) __score3++;
            var __score4 = 0;
            if (__jsonProps.Contains("data")) __score4++;
            if (__jsonProps.Contains("data.assistant_id")) __score4++;
            if (__jsonProps.Contains("data.cancelled_at")) __score4++;
            if (__jsonProps.Contains("data.completed_at")) __score4++;
            if (__jsonProps.Contains("data.created_at")) __score4++;
            if (__jsonProps.Contains("data.expires_at")) __score4++;
            if (__jsonProps.Contains("data.failed_at")) __score4++;
            if (__jsonProps.Contains("data.id")) __score4++;
            if (__jsonProps.Contains("data.incomplete_details")) __score4++;
            if (__jsonProps.Contains("data.instructions")) __score4++;
            if (__jsonProps.Contains("data.last_error")) __score4++;
            if (__jsonProps.Contains("data.max_completion_tokens")) __score4++;
            if (__jsonProps.Contains("data.max_prompt_tokens")) __score4++;
            if (__jsonProps.Contains("data.metadata")) __score4++;
            if (__jsonProps.Contains("data.model")) __score4++;
            if (__jsonProps.Contains("data.object")) __score4++;
            if (__jsonProps.Contains("data.parallel_tool_calls")) __score4++;
            if (__jsonProps.Contains("data.required_action")) __score4++;
            if (__jsonProps.Contains("data.response_format")) __score4++;
            if (__jsonProps.Contains("data.started_at")) __score4++;
            if (__jsonProps.Contains("data.status")) __score4++;
            if (__jsonProps.Contains("data.temperature")) __score4++;
            if (__jsonProps.Contains("data.thread_id")) __score4++;
            if (__jsonProps.Contains("data.tool_choice")) __score4++;
            if (__jsonProps.Contains("data.tools")) __score4++;
            if (__jsonProps.Contains("data.top_p")) __score4++;
            if (__jsonProps.Contains("data.truncation_strategy")) __score4++;
            if (__jsonProps.Contains("data.usage")) __score4++;
            if (__jsonProps.Contains("event")) __score4++;
            var __score5 = 0;
            if (__jsonProps.Contains("data")) __score5++;
            if (__jsonProps.Contains("data.assistant_id")) __score5++;
            if (__jsonProps.Contains("data.cancelled_at")) __score5++;
            if (__jsonProps.Contains("data.completed_at")) __score5++;
            if (__jsonProps.Contains("data.created_at")) __score5++;
            if (__jsonProps.Contains("data.expires_at")) __score5++;
            if (__jsonProps.Contains("data.failed_at")) __score5++;
            if (__jsonProps.Contains("data.id")) __score5++;
            if (__jsonProps.Contains("data.incomplete_details")) __score5++;
            if (__jsonProps.Contains("data.instructions")) __score5++;
            if (__jsonProps.Contains("data.last_error")) __score5++;
            if (__jsonProps.Contains("data.max_completion_tokens")) __score5++;
            if (__jsonProps.Contains("data.max_prompt_tokens")) __score5++;
            if (__jsonProps.Contains("data.metadata")) __score5++;
            if (__jsonProps.Contains("data.model")) __score5++;
            if (__jsonProps.Contains("data.object")) __score5++;
            if (__jsonProps.Contains("data.parallel_tool_calls")) __score5++;
            if (__jsonProps.Contains("data.required_action")) __score5++;
            if (__jsonProps.Contains("data.response_format")) __score5++;
            if (__jsonProps.Contains("data.started_at")) __score5++;
            if (__jsonProps.Contains("data.status")) __score5++;
            if (__jsonProps.Contains("data.temperature")) __score5++;
            if (__jsonProps.Contains("data.thread_id")) __score5++;
            if (__jsonProps.Contains("data.tool_choice")) __score5++;
            if (__jsonProps.Contains("data.tools")) __score5++;
            if (__jsonProps.Contains("data.top_p")) __score5++;
            if (__jsonProps.Contains("data.truncation_strategy")) __score5++;
            if (__jsonProps.Contains("data.usage")) __score5++;
            if (__jsonProps.Contains("event")) __score5++;
            var __score6 = 0;
            if (__jsonProps.Contains("data")) __score6++;
            if (__jsonProps.Contains("data.assistant_id")) __score6++;
            if (__jsonProps.Contains("data.cancelled_at")) __score6++;
            if (__jsonProps.Contains("data.completed_at")) __score6++;
            if (__jsonProps.Contains("data.created_at")) __score6++;
            if (__jsonProps.Contains("data.expires_at")) __score6++;
            if (__jsonProps.Contains("data.failed_at")) __score6++;
            if (__jsonProps.Contains("data.id")) __score6++;
            if (__jsonProps.Contains("data.incomplete_details")) __score6++;
            if (__jsonProps.Contains("data.instructions")) __score6++;
            if (__jsonProps.Contains("data.last_error")) __score6++;
            if (__jsonProps.Contains("data.max_completion_tokens")) __score6++;
            if (__jsonProps.Contains("data.max_prompt_tokens")) __score6++;
            if (__jsonProps.Contains("data.metadata")) __score6++;
            if (__jsonProps.Contains("data.model")) __score6++;
            if (__jsonProps.Contains("data.object")) __score6++;
            if (__jsonProps.Contains("data.parallel_tool_calls")) __score6++;
            if (__jsonProps.Contains("data.required_action")) __score6++;
            if (__jsonProps.Contains("data.response_format")) __score6++;
            if (__jsonProps.Contains("data.started_at")) __score6++;
            if (__jsonProps.Contains("data.status")) __score6++;
            if (__jsonProps.Contains("data.temperature")) __score6++;
            if (__jsonProps.Contains("data.thread_id")) __score6++;
            if (__jsonProps.Contains("data.tool_choice")) __score6++;
            if (__jsonProps.Contains("data.tools")) __score6++;
            if (__jsonProps.Contains("data.top_p")) __score6++;
            if (__jsonProps.Contains("data.truncation_strategy")) __score6++;
            if (__jsonProps.Contains("data.usage")) __score6++;
            if (__jsonProps.Contains("event")) __score6++;
            var __score7 = 0;
            if (__jsonProps.Contains("data")) __score7++;
            if (__jsonProps.Contains("data.assistant_id")) __score7++;
            if (__jsonProps.Contains("data.cancelled_at")) __score7++;
            if (__jsonProps.Contains("data.completed_at")) __score7++;
            if (__jsonProps.Contains("data.created_at")) __score7++;
            if (__jsonProps.Contains("data.expires_at")) __score7++;
            if (__jsonProps.Contains("data.failed_at")) __score7++;
            if (__jsonProps.Contains("data.id")) __score7++;
            if (__jsonProps.Contains("data.incomplete_details")) __score7++;
            if (__jsonProps.Contains("data.instructions")) __score7++;
            if (__jsonProps.Contains("data.last_error")) __score7++;
            if (__jsonProps.Contains("data.max_completion_tokens")) __score7++;
            if (__jsonProps.Contains("data.max_prompt_tokens")) __score7++;
            if (__jsonProps.Contains("data.metadata")) __score7++;
            if (__jsonProps.Contains("data.model")) __score7++;
            if (__jsonProps.Contains("data.object")) __score7++;
            if (__jsonProps.Contains("data.parallel_tool_calls")) __score7++;
            if (__jsonProps.Contains("data.required_action")) __score7++;
            if (__jsonProps.Contains("data.response_format")) __score7++;
            if (__jsonProps.Contains("data.started_at")) __score7++;
            if (__jsonProps.Contains("data.status")) __score7++;
            if (__jsonProps.Contains("data.temperature")) __score7++;
            if (__jsonProps.Contains("data.thread_id")) __score7++;
            if (__jsonProps.Contains("data.tool_choice")) __score7++;
            if (__jsonProps.Contains("data.tools")) __score7++;
            if (__jsonProps.Contains("data.top_p")) __score7++;
            if (__jsonProps.Contains("data.truncation_strategy")) __score7++;
            if (__jsonProps.Contains("data.usage")) __score7++;
            if (__jsonProps.Contains("event")) __score7++;
            var __score8 = 0;
            if (__jsonProps.Contains("data")) __score8++;
            if (__jsonProps.Contains("data.assistant_id")) __score8++;
            if (__jsonProps.Contains("data.cancelled_at")) __score8++;
            if (__jsonProps.Contains("data.completed_at")) __score8++;
            if (__jsonProps.Contains("data.created_at")) __score8++;
            if (__jsonProps.Contains("data.expires_at")) __score8++;
            if (__jsonProps.Contains("data.failed_at")) __score8++;
            if (__jsonProps.Contains("data.id")) __score8++;
            if (__jsonProps.Contains("data.incomplete_details")) __score8++;
            if (__jsonProps.Contains("data.instructions")) __score8++;
            if (__jsonProps.Contains("data.last_error")) __score8++;
            if (__jsonProps.Contains("data.max_completion_tokens")) __score8++;
            if (__jsonProps.Contains("data.max_prompt_tokens")) __score8++;
            if (__jsonProps.Contains("data.metadata")) __score8++;
            if (__jsonProps.Contains("data.model")) __score8++;
            if (__jsonProps.Contains("data.object")) __score8++;
            if (__jsonProps.Contains("data.parallel_tool_calls")) __score8++;
            if (__jsonProps.Contains("data.required_action")) __score8++;
            if (__jsonProps.Contains("data.response_format")) __score8++;
            if (__jsonProps.Contains("data.started_at")) __score8++;
            if (__jsonProps.Contains("data.status")) __score8++;
            if (__jsonProps.Contains("data.temperature")) __score8++;
            if (__jsonProps.Contains("data.thread_id")) __score8++;
            if (__jsonProps.Contains("data.tool_choice")) __score8++;
            if (__jsonProps.Contains("data.tools")) __score8++;
            if (__jsonProps.Contains("data.top_p")) __score8++;
            if (__jsonProps.Contains("data.truncation_strategy")) __score8++;
            if (__jsonProps.Contains("data.usage")) __score8++;
            if (__jsonProps.Contains("event")) __score8++;
            var __score9 = 0;
            if (__jsonProps.Contains("data")) __score9++;
            if (__jsonProps.Contains("data.assistant_id")) __score9++;
            if (__jsonProps.Contains("data.cancelled_at")) __score9++;
            if (__jsonProps.Contains("data.completed_at")) __score9++;
            if (__jsonProps.Contains("data.created_at")) __score9++;
            if (__jsonProps.Contains("data.expires_at")) __score9++;
            if (__jsonProps.Contains("data.failed_at")) __score9++;
            if (__jsonProps.Contains("data.id")) __score9++;
            if (__jsonProps.Contains("data.incomplete_details")) __score9++;
            if (__jsonProps.Contains("data.instructions")) __score9++;
            if (__jsonProps.Contains("data.last_error")) __score9++;
            if (__jsonProps.Contains("data.max_completion_tokens")) __score9++;
            if (__jsonProps.Contains("data.max_prompt_tokens")) __score9++;
            if (__jsonProps.Contains("data.metadata")) __score9++;
            if (__jsonProps.Contains("data.model")) __score9++;
            if (__jsonProps.Contains("data.object")) __score9++;
            if (__jsonProps.Contains("data.parallel_tool_calls")) __score9++;
            if (__jsonProps.Contains("data.required_action")) __score9++;
            if (__jsonProps.Contains("data.response_format")) __score9++;
            if (__jsonProps.Contains("data.started_at")) __score9++;
            if (__jsonProps.Contains("data.status")) __score9++;
            if (__jsonProps.Contains("data.temperature")) __score9++;
            if (__jsonProps.Contains("data.thread_id")) __score9++;
            if (__jsonProps.Contains("data.tool_choice")) __score9++;
            if (__jsonProps.Contains("data.tools")) __score9++;
            if (__jsonProps.Contains("data.top_p")) __score9++;
            if (__jsonProps.Contains("data.truncation_strategy")) __score9++;
            if (__jsonProps.Contains("data.usage")) __score9++;
            if (__jsonProps.Contains("event")) __score9++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }
            if (__score6 > __bestScore) { __bestScore = __score6; __bestIndex = 6; }
            if (__score7 > __bestScore) { __bestScore = __score7; __bestIndex = 7; }
            if (__score8 > __bestScore) { __bestScore = __score8; __bestIndex = 8; }
            if (__score9 > __bestScore) { __bestScore = __score9; __bestIndex = 9; }

            global::G.RunStreamEventVariant1? runStreamEventVariant1 = default;
            global::G.RunStreamEventVariant2? runStreamEventVariant2 = default;
            global::G.RunStreamEventVariant3? runStreamEventVariant3 = default;
            global::G.RunStreamEventVariant4? runStreamEventVariant4 = default;
            global::G.RunStreamEventVariant5? runStreamEventVariant5 = default;
            global::G.RunStreamEventVariant6? runStreamEventVariant6 = default;
            global::G.RunStreamEventVariant7? runStreamEventVariant7 = default;
            global::G.RunStreamEventVariant8? runStreamEventVariant8 = default;
            global::G.RunStreamEventVariant9? runStreamEventVariant9 = default;
            global::G.RunStreamEventVariant10? runStreamEventVariant10 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant1).Name}");
                        runStreamEventVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant2).Name}");
                        runStreamEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant3> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant3).Name}");
                        runStreamEventVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant4> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant4).Name}");
                        runStreamEventVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 4)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant5> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant5).Name}");
                        runStreamEventVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 5)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant6> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant6).Name}");
                        runStreamEventVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 6)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant7> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant7).Name}");
                        runStreamEventVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 7)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant8> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant8).Name}");
                        runStreamEventVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 8)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant9> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant9).Name}");
                        runStreamEventVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 9)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant10> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant10).Name}");
                        runStreamEventVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (runStreamEventVariant1 == null && runStreamEventVariant2 == null && runStreamEventVariant3 == null && runStreamEventVariant4 == null && runStreamEventVariant5 == null && runStreamEventVariant6 == null && runStreamEventVariant7 == null && runStreamEventVariant8 == null && runStreamEventVariant9 == null && runStreamEventVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant1).Name}");
                    runStreamEventVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (runStreamEventVariant1 == null && runStreamEventVariant2 == null && runStreamEventVariant3 == null && runStreamEventVariant4 == null && runStreamEventVariant5 == null && runStreamEventVariant6 == null && runStreamEventVariant7 == null && runStreamEventVariant8 == null && runStreamEventVariant9 == null && runStreamEventVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant2).Name}");
                    runStreamEventVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (runStreamEventVariant1 == null && runStreamEventVariant2 == null && runStreamEventVariant3 == null && runStreamEventVariant4 == null && runStreamEventVariant5 == null && runStreamEventVariant6 == null && runStreamEventVariant7 == null && runStreamEventVariant8 == null && runStreamEventVariant9 == null && runStreamEventVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant3> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant3).Name}");
                    runStreamEventVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (runStreamEventVariant1 == null && runStreamEventVariant2 == null && runStreamEventVariant3 == null && runStreamEventVariant4 == null && runStreamEventVariant5 == null && runStreamEventVariant6 == null && runStreamEventVariant7 == null && runStreamEventVariant8 == null && runStreamEventVariant9 == null && runStreamEventVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant4> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant4).Name}");
                    runStreamEventVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (runStreamEventVariant1 == null && runStreamEventVariant2 == null && runStreamEventVariant3 == null && runStreamEventVariant4 == null && runStreamEventVariant5 == null && runStreamEventVariant6 == null && runStreamEventVariant7 == null && runStreamEventVariant8 == null && runStreamEventVariant9 == null && runStreamEventVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant5> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant5).Name}");
                    runStreamEventVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (runStreamEventVariant1 == null && runStreamEventVariant2 == null && runStreamEventVariant3 == null && runStreamEventVariant4 == null && runStreamEventVariant5 == null && runStreamEventVariant6 == null && runStreamEventVariant7 == null && runStreamEventVariant8 == null && runStreamEventVariant9 == null && runStreamEventVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant6> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant6).Name}");
                    runStreamEventVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (runStreamEventVariant1 == null && runStreamEventVariant2 == null && runStreamEventVariant3 == null && runStreamEventVariant4 == null && runStreamEventVariant5 == null && runStreamEventVariant6 == null && runStreamEventVariant7 == null && runStreamEventVariant8 == null && runStreamEventVariant9 == null && runStreamEventVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant7> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant7).Name}");
                    runStreamEventVariant7 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (runStreamEventVariant1 == null && runStreamEventVariant2 == null && runStreamEventVariant3 == null && runStreamEventVariant4 == null && runStreamEventVariant5 == null && runStreamEventVariant6 == null && runStreamEventVariant7 == null && runStreamEventVariant8 == null && runStreamEventVariant9 == null && runStreamEventVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant8> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant8).Name}");
                    runStreamEventVariant8 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (runStreamEventVariant1 == null && runStreamEventVariant2 == null && runStreamEventVariant3 == null && runStreamEventVariant4 == null && runStreamEventVariant5 == null && runStreamEventVariant6 == null && runStreamEventVariant7 == null && runStreamEventVariant8 == null && runStreamEventVariant9 == null && runStreamEventVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant9> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant9).Name}");
                    runStreamEventVariant9 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (runStreamEventVariant1 == null && runStreamEventVariant2 == null && runStreamEventVariant3 == null && runStreamEventVariant4 == null && runStreamEventVariant5 == null && runStreamEventVariant6 == null && runStreamEventVariant7 == null && runStreamEventVariant8 == null && runStreamEventVariant9 == null && runStreamEventVariant10 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant10> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant10).Name}");
                    runStreamEventVariant10 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.RunStreamEvent(
                runStreamEventVariant1,

                runStreamEventVariant2,

                runStreamEventVariant3,

                runStreamEventVariant4,

                runStreamEventVariant5,

                runStreamEventVariant6,

                runStreamEventVariant7,

                runStreamEventVariant8,

                runStreamEventVariant9,

                runStreamEventVariant10
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RunStreamEvent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRunStreamEventVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant1!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant2!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant3), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant3?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant3).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant3!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant4), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant4?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant4).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant4!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant5), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant5?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant5).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant5!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant6), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant6?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant6).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant6!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant7)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant7), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant7?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant7).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant7!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant8)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant8), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant8?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant8).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant8!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant9)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant9), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant9?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant9).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant9!, typeInfo);
            }
            else if (value.IsRunStreamEventVariant10)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RunStreamEventVariant10), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RunStreamEventVariant10?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RunStreamEventVariant10).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RunStreamEventVariant10!, typeInfo);
            }
        }
    }
}