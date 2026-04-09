//HintName: G.JsonConverters.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsRepositoryHooks.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsRepositoryHooksJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsRepositoryHooks>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsRepositoryHooks ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsRepositoryHooks existingValue,
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
                        return global::G.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsRepositoryHooksExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsRepositoryHooks)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsRepositoryHooks);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsRepositoryHooks value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsRepositoryHooksExtensions.ToValueString(value));
        }
    }
}
