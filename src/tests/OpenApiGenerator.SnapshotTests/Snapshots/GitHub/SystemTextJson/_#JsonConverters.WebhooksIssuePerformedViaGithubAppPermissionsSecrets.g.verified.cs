//HintName: JsonConverters.WebhooksIssuePerformedViaGithubAppPermissionsSecrets.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksIssuePerformedViaGithubAppPermissionsSecretsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhooksIssuePerformedViaGithubAppPermissionsSecrets>
    {
        /// <inheritdoc />
        public override global::G.WebhooksIssuePerformedViaGithubAppPermissionsSecrets Read(
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
                        return global::G.WebhooksIssuePerformedViaGithubAppPermissionsSecretsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhooksIssuePerformedViaGithubAppPermissionsSecrets)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhooksIssuePerformedViaGithubAppPermissionsSecrets value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhooksIssuePerformedViaGithubAppPermissionsSecretsExtensions.ToValueString(value));
        }
    }
}
