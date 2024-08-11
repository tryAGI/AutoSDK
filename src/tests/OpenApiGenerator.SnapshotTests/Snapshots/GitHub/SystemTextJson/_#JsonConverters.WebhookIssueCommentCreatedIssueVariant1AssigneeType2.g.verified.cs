//HintName: JsonConverters.WebhookIssueCommentCreatedIssueVariant1AssigneeType2.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentCreatedIssueVariant1AssigneeType2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssueCommentCreatedIssueVariant1AssigneeType2>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentCreatedIssueVariant1AssigneeType2 Read(
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
                        return global::G.WebhookIssueCommentCreatedIssueVariant1AssigneeType2Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssueCommentCreatedIssueVariant1AssigneeType2)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssueCommentCreatedIssueVariant1AssigneeType2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookIssueCommentCreatedIssueVariant1AssigneeType2Extensions.ToValueString(value));
        }
    }
}
