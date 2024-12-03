//HintName: JsonConverters.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsEnvironments.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsEnvironmentsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsEnvironments>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsEnvironments Read(
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
                        return global::G.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsEnvironmentsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsEnvironments)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsEnvironments value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookIssuesEditedIssuePerformedViaGithubAppPermissionsEnvironmentsExtensions.ToValueString(value));
        }
    }
}
