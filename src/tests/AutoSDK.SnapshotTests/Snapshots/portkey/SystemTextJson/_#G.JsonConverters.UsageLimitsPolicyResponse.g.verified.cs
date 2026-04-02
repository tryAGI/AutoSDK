//HintName: G.JsonConverters.UsageLimitsPolicyResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class UsageLimitsPolicyResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.UsageLimitsPolicyResponse>
    {
        /// <inheritdoc />
        public override global::G.UsageLimitsPolicyResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

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
            if (__jsonProps.Contains("alert_threshold")) __score0++;
            if (__jsonProps.Contains("conditions")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("credit_limit")) __score0++;
            if (__jsonProps.Contains("group_by")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("last_updated_at")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("organisation_id")) __score0++;
            if (__jsonProps.Contains("periodic_reset")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("value_key_usage_map")) __score0++;
            if (__jsonProps.Contains("workspace_id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("object")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.UsageLimitsPolicy? usageLimitsPolicy = default;
            global::G.UsageLimitsPolicyResponseVariant2? usageLimitsPolicyResponseVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        usageLimitsPolicy = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UsageLimitsPolicy>(__rawJson, options);
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
                        usageLimitsPolicyResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UsageLimitsPolicyResponseVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (usageLimitsPolicy == null && usageLimitsPolicyResponseVariant2 == null)
            {
                try
                {
                    usageLimitsPolicy = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UsageLimitsPolicy>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    usageLimitsPolicyResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.UsageLimitsPolicyResponseVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.UsageLimitsPolicyResponse(
                usageLimitsPolicy,

                usageLimitsPolicyResponseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.UsageLimitsPolicyResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsUsageLimitsPolicy)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UsageLimitsPolicy, typeof(global::G.UsageLimitsPolicy), options);
            }
            else if (value.IsUsageLimitsPolicyResponseVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.UsageLimitsPolicyResponseVariant2, typeof(global::G.UsageLimitsPolicyResponseVariant2), options);
            }
        }
    }
}