//HintName: G.JsonConverters.RateLimitsPolicyResponse.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class RateLimitsPolicyResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RateLimitsPolicyResponse>
    {
        /// <inheritdoc />
        public override global::G.RateLimitsPolicyResponse Read(
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
            if (__jsonProps.Contains("conditions")) __score0++;
            if (__jsonProps.Contains("created_at")) __score0++;
            if (__jsonProps.Contains("group_by")) __score0++;
            if (__jsonProps.Contains("id")) __score0++;
            if (__jsonProps.Contains("last_updated_at")) __score0++;
            if (__jsonProps.Contains("name")) __score0++;
            if (__jsonProps.Contains("organisation_id")) __score0++;
            if (__jsonProps.Contains("status")) __score0++;
            if (__jsonProps.Contains("type")) __score0++;
            if (__jsonProps.Contains("unit")) __score0++;
            if (__jsonProps.Contains("value")) __score0++;
            if (__jsonProps.Contains("workspace_id")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("object")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.RateLimitsPolicy? rateLimitsPolicy = default;
            global::G.RateLimitsPolicyResponseVariant2? rateLimitsPolicyResponseVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RateLimitsPolicy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RateLimitsPolicy> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RateLimitsPolicy).Name}");
                        rateLimitsPolicy = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RateLimitsPolicyResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RateLimitsPolicyResponseVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RateLimitsPolicyResponseVariant2).Name}");
                        rateLimitsPolicyResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (rateLimitsPolicy == null && rateLimitsPolicyResponseVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RateLimitsPolicy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RateLimitsPolicy> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RateLimitsPolicy).Name}");
                    rateLimitsPolicy = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RateLimitsPolicyResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RateLimitsPolicyResponseVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RateLimitsPolicyResponseVariant2).Name}");
                    rateLimitsPolicyResponseVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.RateLimitsPolicyResponse(
                rateLimitsPolicy,

                rateLimitsPolicyResponseVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RateLimitsPolicyResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRateLimitsPolicy)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RateLimitsPolicy), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RateLimitsPolicy?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RateLimitsPolicy).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitsPolicy!, typeInfo);
            }
            else if (value.IsRateLimitsPolicyResponseVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.RateLimitsPolicyResponseVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.RateLimitsPolicyResponseVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.RateLimitsPolicyResponseVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.RateLimitsPolicyResponseVariant2!, typeInfo);
            }
        }
    }
}