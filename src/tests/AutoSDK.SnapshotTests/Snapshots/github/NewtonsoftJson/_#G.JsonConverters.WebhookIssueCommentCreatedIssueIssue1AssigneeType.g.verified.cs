//HintName: G.JsonConverters.WebhookIssueCommentCreatedIssueIssue1AssigneeType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssueCommentCreatedIssueIssue1AssigneeTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookIssueCommentCreatedIssueIssue1AssigneeType>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssueCommentCreatedIssueIssue1AssigneeType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookIssueCommentCreatedIssueIssue1AssigneeType existingValue,
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
                        return global::G.WebhookIssueCommentCreatedIssueIssue1AssigneeTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookIssueCommentCreatedIssueIssue1AssigneeType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookIssueCommentCreatedIssueIssue1AssigneeType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookIssueCommentCreatedIssueIssue1AssigneeType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookIssueCommentCreatedIssueIssue1AssigneeTypeExtensions.ToValueString(value));
        }
    }
}
