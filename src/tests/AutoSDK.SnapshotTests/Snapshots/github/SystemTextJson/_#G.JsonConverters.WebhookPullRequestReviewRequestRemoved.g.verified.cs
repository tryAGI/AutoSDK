//HintName: G.JsonConverters.WebhookPullRequestReviewRequestRemoved.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class WebhookPullRequestReviewRequestRemovedJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestReviewRequestRemoved>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestReviewRequestRemoved Read(
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
            if (__jsonProps.Contains("action")) __score0++;
            if (__jsonProps.Contains("enterprise")) __score0++;
            if (__jsonProps.Contains("installation")) __score0++;
            if (__jsonProps.Contains("number")) __score0++;
            if (__jsonProps.Contains("organization")) __score0++;
            if (__jsonProps.Contains("pull_request")) __score0++;
            if (__jsonProps.Contains("repository")) __score0++;
            if (__jsonProps.Contains("requested_reviewer")) __score0++;
            if (__jsonProps.Contains("sender")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("action")) __score1++;
            if (__jsonProps.Contains("enterprise")) __score1++;
            if (__jsonProps.Contains("installation")) __score1++;
            if (__jsonProps.Contains("number")) __score1++;
            if (__jsonProps.Contains("organization")) __score1++;
            if (__jsonProps.Contains("pull_request")) __score1++;
            if (__jsonProps.Contains("repository")) __score1++;
            if (__jsonProps.Contains("requested_team")) __score1++;
            if (__jsonProps.Contains("sender")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::G.WebhookPullRequestReviewRequestRemovedVariant1? webhookPullRequestReviewRequestRemovedVariant1 = default;
            global::G.WebhookPullRequestReviewRequestRemovedVariant2? webhookPullRequestReviewRequestRemovedVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookPullRequestReviewRequestRemovedVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookPullRequestReviewRequestRemovedVariant1> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebhookPullRequestReviewRequestRemovedVariant1).Name}");
                        webhookPullRequestReviewRequestRemovedVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
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
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookPullRequestReviewRequestRemovedVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookPullRequestReviewRequestRemovedVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebhookPullRequestReviewRequestRemovedVariant2).Name}");
                        webhookPullRequestReviewRequestRemovedVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (webhookPullRequestReviewRequestRemovedVariant1 == null && webhookPullRequestReviewRequestRemovedVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookPullRequestReviewRequestRemovedVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookPullRequestReviewRequestRemovedVariant1> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebhookPullRequestReviewRequestRemovedVariant1).Name}");
                    webhookPullRequestReviewRequestRemovedVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookPullRequestReviewRequestRemovedVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookPullRequestReviewRequestRemovedVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebhookPullRequestReviewRequestRemovedVariant2).Name}");
                    webhookPullRequestReviewRequestRemovedVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.WebhookPullRequestReviewRequestRemoved(
                webhookPullRequestReviewRequestRemovedVariant1,

                webhookPullRequestReviewRequestRemovedVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestReviewRequestRemoved value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWebhookPullRequestReviewRequestRemovedVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookPullRequestReviewRequestRemovedVariant1), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookPullRequestReviewRequestRemovedVariant1?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebhookPullRequestReviewRequestRemovedVariant1).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebhookPullRequestReviewRequestRemovedVariant1!, typeInfo);
            }
            else if (value.IsWebhookPullRequestReviewRequestRemovedVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.WebhookPullRequestReviewRequestRemovedVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.WebhookPullRequestReviewRequestRemovedVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.WebhookPullRequestReviewRequestRemovedVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebhookPullRequestReviewRequestRemovedVariant2!, typeInfo);
            }
        }
    }
}