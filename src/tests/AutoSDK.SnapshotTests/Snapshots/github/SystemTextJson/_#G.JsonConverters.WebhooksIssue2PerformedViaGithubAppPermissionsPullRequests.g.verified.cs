//HintName: G.JsonConverters.WebhooksIssue2PerformedViaGithubAppPermissionsPullRequests.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksIssue2PerformedViaGithubAppPermissionsPullRequestsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhooksIssue2PerformedViaGithubAppPermissionsPullRequests>
    {
        /// <inheritdoc />
        public override global::G.WebhooksIssue2PerformedViaGithubAppPermissionsPullRequests Read(
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
                        return global::G.WebhooksIssue2PerformedViaGithubAppPermissionsPullRequestsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhooksIssue2PerformedViaGithubAppPermissionsPullRequests)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.WebhooksIssue2PerformedViaGithubAppPermissionsPullRequests);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhooksIssue2PerformedViaGithubAppPermissionsPullRequests value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.WebhooksIssue2PerformedViaGithubAppPermissionsPullRequestsExtensions.ToValueString(value));
        }
    }
}
