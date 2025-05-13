//HintName: JsonConverters.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecksNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecksNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecks?>
    {
        /// <inheritdoc />
        public override global::G.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecks? Read(
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
                        return global::G.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecksExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecks)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecks?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecks? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookDeploymentCreatedDeploymentPerformedViaGithubAppPermissionsChecksExtensions.ToValueString(value.Value));
            }
        }
    }
}
