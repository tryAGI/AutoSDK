//HintName: JsonConverters.CodeSecurityUpdateConfigurationRequestDependabotAlerts.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeSecurityUpdateConfigurationRequestDependabotAlertsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CodeSecurityUpdateConfigurationRequestDependabotAlerts>
    {
        /// <inheritdoc />
        public override global::G.CodeSecurityUpdateConfigurationRequestDependabotAlerts Read(
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
                        return global::G.CodeSecurityUpdateConfigurationRequestDependabotAlertsExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CodeSecurityUpdateConfigurationRequestDependabotAlerts)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CodeSecurityUpdateConfigurationRequestDependabotAlerts value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.CodeSecurityUpdateConfigurationRequestDependabotAlertsExtensions.ToValueString(value));
        }
    }
}
