//HintName: JsonConverters.WebhookIssueCommentEditedIssueVariant1AssigneeType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentEditedIssueVariant1AssigneeTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssueCommentEditedIssueVariant1AssigneeType>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentEditedIssueVariant1AssigneeType Read(
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
                        return global::G.WebhookIssueCommentEditedIssueVariant1AssigneeTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssueCommentEditedIssueVariant1AssigneeType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssueCommentEditedIssueVariant1AssigneeType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookIssueCommentEditedIssueVariant1AssigneeTypeExtensions.ToValueString(value));
        }
    }
}
