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
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("cache_metrics")) __score0++;
            if (__jsonProps.Contains("experiment")) __score0++;
            if (__jsonProps.Contains("experiment_hypothesis_run")) __score0++;
            if (__jsonProps.Contains("feedback")) __score0++;
            if (__jsonProps.Contains("job")) __score0++;
            if (__jsonProps.Contains("job_node")) __score0++;
            if (__jsonProps.Contains("organization_properties")) __score0++;
            if (__jsonProps.Contains("prompt_v2")) __score0++;
            if (__jsonProps.Contains("prompts_versions")) __score0++;
            if (__jsonProps.Contains("properties")) __score0++;
            if (__jsonProps.Contains("properties_table")) __score0++;
            if (__jsonProps.Contains("properties_v3")) __score0++;
            if (__jsonProps.Contains("property_with_response_v1")) __score0++;
            if (__jsonProps.Contains("rate_limit_log")) __score0++;
            if (__jsonProps.Contains("request")) __score0++;
            if (__jsonProps.Contains("request_response_log")) __score0++;
            if (__jsonProps.Contains("request_response_rmt")) __score0++;
            if (__jsonProps.Contains("response")) __score0++;
            if (__jsonProps.Contains("score_value")) __score0++;
            if (__jsonProps.Contains("sessions_request_response_rmt")) __score0++;
            if (__jsonProps.Contains("user_api_keys")) __score0++;
            if (__jsonProps.Contains("user_metrics")) __score0++;
            if (__jsonProps.Contains("users_view")) __score0++;
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

            global::G.PartialTablesAndViews? value1 = default;
            global::G.FilterBranch? value2 = default;
            object? value3 = default;
            global::G.FilterNodeEnum2? value4 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PartialTablesAndViews), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PartialTablesAndViews> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PartialTablesAndViews).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FilterBranch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FilterBranch> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FilterBranch).Name}");
                        value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value1 == null && value2 == null && value3 == null && value4 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PartialTablesAndViews), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PartialTablesAndViews> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PartialTablesAndViews).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FilterBranch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FilterBranch> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FilterBranch).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    value3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FilterNodeEnum2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FilterNodeEnum2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FilterNodeEnum2).Name}");
                    value4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.FilterNode(
                value1,

                value2,

                value3,

                value4
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

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PartialTablesAndViews), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PartialTablesAndViews?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PartialTablesAndViews).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1!, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FilterBranch), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FilterBranch?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FilterBranch).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2!, typeInfo);
            }
            else if (value.IsValue3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value3!, typeInfo);
            }
            else if (value.IsValue4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.FilterNodeEnum2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.FilterNodeEnum2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.FilterNodeEnum2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value4!.Value, typeInfo);
            }
        }
    }
}