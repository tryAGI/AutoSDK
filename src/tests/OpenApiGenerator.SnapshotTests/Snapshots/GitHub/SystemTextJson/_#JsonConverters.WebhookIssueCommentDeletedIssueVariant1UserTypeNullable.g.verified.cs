//HintName: JsonConverters.WebhookIssueCommentDeletedIssueVariant1UserTypeNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentDeletedIssueVariant1UserTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssueCommentDeletedIssueVariant1UserType?>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentDeletedIssueVariant1UserType? Read(
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
                        return global::G.WebhookIssueCommentDeletedIssueVariant1UserTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssueCommentDeletedIssueVariant1UserType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssueCommentDeletedIssueVariant1UserType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookIssueCommentDeletedIssueVariant1UserTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
