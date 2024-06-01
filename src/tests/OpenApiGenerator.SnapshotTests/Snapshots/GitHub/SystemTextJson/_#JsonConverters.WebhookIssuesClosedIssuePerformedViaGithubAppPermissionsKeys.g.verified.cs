//HintName: JsonConverters.WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsKeys.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsKeysJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsKeys>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsKeys Read(
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
                        return global::G.WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsKeysExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsKeys)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsKeys value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsKeysExtensions.ToValueString(value));
        }
    }
}
