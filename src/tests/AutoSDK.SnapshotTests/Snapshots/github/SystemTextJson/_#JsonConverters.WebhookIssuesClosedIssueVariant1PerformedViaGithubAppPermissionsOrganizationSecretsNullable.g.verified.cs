//HintName: JsonConverters.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSecretsNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSecretsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSecrets?>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSecrets? Read(
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
                        return global::G.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSecretsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSecrets)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSecrets?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSecrets? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsOrganizationSecretsExtensions.ToValueString(value.Value));
            }
        }
    }
}
