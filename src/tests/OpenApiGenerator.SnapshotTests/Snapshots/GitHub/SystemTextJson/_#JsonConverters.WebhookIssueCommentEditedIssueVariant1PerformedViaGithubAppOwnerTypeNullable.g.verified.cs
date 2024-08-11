//HintName: JsonConverters.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerTypeNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerType?>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerType? Read(
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
                        return global::G.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
