//HintName: JsonConverters.CodeSecurityConfigurationSecretScanningValidityChecks.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeSecurityConfigurationSecretScanningValidityChecksJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CodeSecurityConfigurationSecretScanningValidityChecks>
    {
        /// <inheritdoc />
        public override global::G.CodeSecurityConfigurationSecretScanningValidityChecks Read(
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
                        return global::G.CodeSecurityConfigurationSecretScanningValidityChecksExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CodeSecurityConfigurationSecretScanningValidityChecks)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CodeSecurityConfigurationSecretScanningValidityChecks value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.CodeSecurityConfigurationSecretScanningValidityChecksExtensions.ToValueString(value));
        }
    }
}
