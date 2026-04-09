//HintName: G.JsonConverters.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsActions.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsActionsJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsActions>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsActions ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsActions existingValue,
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
                        return global::G.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsActionsExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsActions)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsActions);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsActions value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsActionsExtensions.ToValueString(value));
        }
    }
}
