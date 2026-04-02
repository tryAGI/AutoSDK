//HintName: G.JsonConverters.WebhookPullRequestReviewRequested.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class WebhookPullRequestReviewRequestedJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestReviewRequested>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestReviewRequested Read(
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

            global::G.WebhookPullRequestReviewRequestedVariant1? webhookPullRequestReviewRequestedVariant1 = default;
            global::G.WebhookPullRequestReviewRequestedVariant2? webhookPullRequestReviewRequestedVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        webhookPullRequestReviewRequestedVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebhookPullRequestReviewRequestedVariant1>(__rawJson, options);
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
                        webhookPullRequestReviewRequestedVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebhookPullRequestReviewRequestedVariant2>(__rawJson, options);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (webhookPullRequestReviewRequestedVariant1 == null && webhookPullRequestReviewRequestedVariant2 == null)
            {
                try
                {
                    webhookPullRequestReviewRequestedVariant1 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebhookPullRequestReviewRequestedVariant1>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    webhookPullRequestReviewRequestedVariant2 = global::System.Text.Json.JsonSerializer.Deserialize<global::G.WebhookPullRequestReviewRequestedVariant2>(__rawJson, options);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::G.WebhookPullRequestReviewRequested(
                webhookPullRequestReviewRequestedVariant1,

                webhookPullRequestReviewRequestedVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestReviewRequested value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsWebhookPullRequestReviewRequestedVariant1)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebhookPullRequestReviewRequestedVariant1, typeof(global::G.WebhookPullRequestReviewRequestedVariant1), options);
            }
            else if (value.IsWebhookPullRequestReviewRequestedVariant2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebhookPullRequestReviewRequestedVariant2, typeof(global::G.WebhookPullRequestReviewRequestedVariant2), options);
            }
        }
    }
}