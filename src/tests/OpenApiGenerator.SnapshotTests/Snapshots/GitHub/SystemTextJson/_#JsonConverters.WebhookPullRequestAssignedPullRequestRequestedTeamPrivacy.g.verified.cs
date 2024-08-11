//HintName: JsonConverters.WebhookPullRequestAssignedPullRequestRequestedTeamPrivacy.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookPullRequestAssignedPullRequestRequestedTeamPrivacyJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookPullRequestAssignedPullRequestRequestedTeamPrivacy>
    {
        /// <inheritdoc />
        public override global::G.WebhookPullRequestAssignedPullRequestRequestedTeamPrivacy Read(
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
                        return global::G.WebhookPullRequestAssignedPullRequestRequestedTeamPrivacyExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookPullRequestAssignedPullRequestRequestedTeamPrivacy)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookPullRequestAssignedPullRequestRequestedTeamPrivacy value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookPullRequestAssignedPullRequestRequestedTeamPrivacyExtensions.ToValueString(value));
        }
    }
}
