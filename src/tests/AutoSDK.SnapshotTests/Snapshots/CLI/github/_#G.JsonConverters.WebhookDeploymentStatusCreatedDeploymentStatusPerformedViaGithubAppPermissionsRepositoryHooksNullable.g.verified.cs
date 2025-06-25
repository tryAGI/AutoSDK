﻿//HintName: G.JsonConverters.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryHooksNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryHooksNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryHooks?>
    {
        /// <inheritdoc />
        public override global::G.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryHooks? Read(
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
                        return global::G.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryHooksExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryHooks)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryHooks?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryHooks? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookDeploymentStatusCreatedDeploymentStatusPerformedViaGithubAppPermissionsRepositoryHooksExtensions.ToValueString(value.Value));
            }
        }
    }
}
