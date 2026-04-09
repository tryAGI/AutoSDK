//HintName: G.JsonConverters.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsPackages.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsPackagesJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsPackages>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsPackages ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsPackages existingValue,
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
                        return global::G.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsPackagesExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsPackages)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsPackages);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsPackages value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsPackagesExtensions.ToValueString(value));
        }
    }
}
