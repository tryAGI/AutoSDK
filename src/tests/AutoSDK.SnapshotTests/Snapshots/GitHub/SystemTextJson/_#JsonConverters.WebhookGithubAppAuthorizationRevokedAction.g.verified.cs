//HintName: JsonConverters.WebhookGithubAppAuthorizationRevokedAction.g.cs
#nullable enable

namespace AutoSDK.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookGithubAppAuthorizationRevokedActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookGithubAppAuthorizationRevokedAction>
    {
        /// <inheritdoc />
        public override global::G.WebhookGithubAppAuthorizationRevokedAction Read(
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
                        return global::G.WebhookGithubAppAuthorizationRevokedActionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookGithubAppAuthorizationRevokedAction)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookGithubAppAuthorizationRevokedAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhookGithubAppAuthorizationRevokedActionExtensions.ToValueString(value));
        }
    }
}
