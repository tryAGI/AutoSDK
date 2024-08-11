//HintName: JsonConverters.WebhookIssueCommentDeletedIssueVariant2AssigneeTypeNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentDeletedIssueVariant2AssigneeTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssueCommentDeletedIssueVariant2AssigneeType?>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentDeletedIssueVariant2AssigneeType? Read(
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
                        return global::G.WebhookIssueCommentDeletedIssueVariant2AssigneeTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssueCommentDeletedIssueVariant2AssigneeType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssueCommentDeletedIssueVariant2AssigneeType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookIssueCommentDeletedIssueVariant2AssigneeTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
