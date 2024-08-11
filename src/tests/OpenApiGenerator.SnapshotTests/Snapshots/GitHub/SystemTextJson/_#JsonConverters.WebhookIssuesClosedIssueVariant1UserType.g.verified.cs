//HintName: JsonConverters.WebhookIssuesClosedIssueVariant1UserType.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookIssuesClosedIssueVariant1UserTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookIssuesClosedIssueVariant1UserType>
    {
        /// <inheritdoc />
        public override global::G.WebhookIssuesClosedIssueVariant1UserType Read(
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
                        return global::G.WebhookIssuesClosedIssueVariant1UserTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookIssuesClosedIssueVariant1UserType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookIssuesClosedIssueVariant1UserType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookIssuesClosedIssueVariant1UserTypeExtensions.ToValueString(value));
        }
    }
}
