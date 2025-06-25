﻿//HintName: G.JsonConverters.WebhookIssuesDeletedIssueAssigneeType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesDeletedIssueAssigneeTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssuesDeletedIssueAssigneeType>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesDeletedIssueAssigneeType Read(
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
                        return global::G.WebhookIssuesDeletedIssueAssigneeTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssuesDeletedIssueAssigneeType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookIssuesDeletedIssueAssigneeType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssuesDeletedIssueAssigneeType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookIssuesDeletedIssueAssigneeTypeExtensions.ToValueString(value));
        }
    }
}
