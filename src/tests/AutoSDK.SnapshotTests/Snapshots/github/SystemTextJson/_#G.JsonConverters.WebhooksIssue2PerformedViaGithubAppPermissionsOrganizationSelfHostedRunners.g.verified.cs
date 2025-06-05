//HintName: G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners>
    {
        /// <inheritdoc />
        public override global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners Read(
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
                        return global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSelfHostedRunners value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhooksIssue2PerformedViaGithubAppPermissionsOrganizationSelfHostedRunnersExtensions.ToValueString(value));
        }
    }
}
