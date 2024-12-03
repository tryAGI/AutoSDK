//HintName: JsonConverters.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunnersNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunnersNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners?>
    {
        /// <inheritdoc />
        public override global::G.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? Read(
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
                        return global::G.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunnersExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunners? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationSelfHostedRunnersExtensions.ToValueString(value.Value));
            }
        }
    }
}
