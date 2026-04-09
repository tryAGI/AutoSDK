//HintName: G.JsonConverters.WebhookIssuesDeletedIssuePerformedViaGithubAppEvent.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesDeletedIssuePerformedViaGithubAppEventJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppEvent>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppEvent ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppEvent existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppEventExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppEvent)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppEvent);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppEvent value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookIssuesDeletedIssuePerformedViaGithubAppEventExtensions.ToValueString(value));
        }
    }
}
