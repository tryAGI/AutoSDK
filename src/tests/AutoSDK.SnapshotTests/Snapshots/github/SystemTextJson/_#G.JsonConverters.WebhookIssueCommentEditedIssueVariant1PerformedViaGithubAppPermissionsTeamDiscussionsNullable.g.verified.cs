﻿//HintName: G.JsonConverters.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussionsNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussionsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussions?>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussions? Read(
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
                        return global::G.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussionsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussions)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussions?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussions? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussionsExtensions.ToValueString(value.Value));
            }
        }
    }
}
