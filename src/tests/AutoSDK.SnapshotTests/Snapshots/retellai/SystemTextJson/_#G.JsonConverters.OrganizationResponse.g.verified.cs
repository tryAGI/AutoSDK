//HintName: G.JsonConverters.OrganizationResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class OrganizationResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OrganizationResponse>
    {
        /// <inheritdoc />
        public override global::G.OrganizationResponse Read(
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
            if (__jsonProps.Contains("concurrency")) __score0++;
            if (__jsonProps.Contains("concurrency_burst_enabled")) __score0++;
            if (__jsonProps.Contains("cps_config")) __score0++;
            if (__jsonProps.Contains("created_timestamp")) __score0++;
            if (__jsonProps.Contains("custom_voice_ids")) __score0++;
            if (__jsonProps.Contains("enterprise_id")) __score0++;
            if (__jsonProps.Contains("feature_bucket")) __score0++;
            if (__jsonProps.Contains("kyc_passed")) __score0++;
            if (__jsonProps.Contains("max_call_duration_ms")) __score0++;
            if (__jsonProps.Contains("max_token_length")) __score0++;
            if (__jsonProps.Contains("orgName")) __score0++;
            if (__jsonProps.Contains("org_name")) __score0++;
            if (__jsonProps.Contains("outage_mode_enabled")) __score0++;
            if (__jsonProps.Contains("review_provided")) __score0++;
            if (__jsonProps.Contains("skip_audit")) __score0++;
            if (__jsonProps.Contains("twilio_subaccount_sid")) __score0++;
            if (__jsonProps.Contains("use_stable_server")) __score0++;
            if (__jsonProps.Contains("webhook_key")) __score0++;
            if (__jsonProps.Contains("webhook_urls")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("org_id")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.Organization? value1 = default;
            global::G.OrganizationResponseVariant2? value2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Organization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Organization> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Organization).Name}");
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OrganizationResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OrganizationResponseVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OrganizationResponseVariant2).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Organization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Organization> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Organization).Name}");
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
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OrganizationResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OrganizationResponseVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OrganizationResponseVariant2).Name}");
                    value2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.OrganizationResponse(
                value1,

                value2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OrganizationResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Organization), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Organization?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Organization).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value1, typeInfo);
            }
            else if (value.IsValue2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.OrganizationResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.OrganizationResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.OrganizationResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value2, typeInfo);
            }
        }
    }
}