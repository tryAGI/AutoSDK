﻿//HintName: JsonConverters.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecrets.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecretsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecrets>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecrets Read(
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
                        return global::G.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecretsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecrets)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecrets);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecrets value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecretsExtensions.ToValueString(value));
        }
    }
}
