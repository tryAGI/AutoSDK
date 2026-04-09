//HintName: G.JsonConverters.WebhookIssueCommentEditedIssueIssue1AssigneeTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentEditedIssueIssue1AssigneeTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookIssueCommentEditedIssueIssue1AssigneeType?>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentEditedIssueIssue1AssigneeType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookIssueCommentEditedIssueIssue1AssigneeType? existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.WebhookIssueCommentEditedIssueIssue1AssigneeTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookIssueCommentEditedIssueIssue1AssigneeType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookIssueCommentEditedIssueIssue1AssigneeType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookIssueCommentEditedIssueIssue1AssigneeType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.WebhookIssueCommentEditedIssueIssue1AssigneeTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
