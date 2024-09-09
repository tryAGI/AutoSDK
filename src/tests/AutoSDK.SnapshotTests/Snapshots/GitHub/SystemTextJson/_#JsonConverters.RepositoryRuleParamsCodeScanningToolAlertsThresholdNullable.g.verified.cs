//HintName: JsonConverters.RepositoryRuleParamsCodeScanningToolAlertsThresholdNullable.g.cs
#nullable enable

namespace AutoSDK.JsonConverters
{
    /// <inheritdoc />
    public sealed class RepositoryRuleParamsCodeScanningToolAlertsThresholdNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RepositoryRuleParamsCodeScanningToolAlertsThreshold?>
    {
        /// <inheritdoc />
        public override global::G.RepositoryRuleParamsCodeScanningToolAlertsThreshold? Read(
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
                        return global::G.RepositoryRuleParamsCodeScanningToolAlertsThresholdExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.RepositoryRuleParamsCodeScanningToolAlertsThreshold)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RepositoryRuleParamsCodeScanningToolAlertsThreshold? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.RepositoryRuleParamsCodeScanningToolAlertsThresholdExtensions.ToValueString(value.Value));
            }
        }
    }
}
