﻿//HintName: JsonConverters.WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsEmails.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsEmailsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsEmails>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsEmails Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsEmailsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsEmails)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsEmails value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsEmailsExtensions.ToValueString(value));
        }
    }
}