//HintName: G.JsonConverters.WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministration.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministrationJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministration>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministration ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministration existingValue,
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
                        return global::G.WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministrationExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministration)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministration);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministration value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookIssuesClosedIssueIssue1PerformedViaGithubAppPermissionsAdministrationExtensions.ToValueString(value));
        }
    }
}
