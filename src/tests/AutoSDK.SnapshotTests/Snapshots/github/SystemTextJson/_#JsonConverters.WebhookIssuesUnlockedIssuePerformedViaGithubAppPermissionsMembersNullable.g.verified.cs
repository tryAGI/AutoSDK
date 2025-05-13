//HintName: JsonConverters.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembersNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembersNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembers?>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembers? Read(
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
                        return global::G.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembersExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembers)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembers?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembers? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookIssuesUnlockedIssuePerformedViaGithubAppPermissionsMembersExtensions.ToValueString(value.Value));
            }
        }
    }
}
