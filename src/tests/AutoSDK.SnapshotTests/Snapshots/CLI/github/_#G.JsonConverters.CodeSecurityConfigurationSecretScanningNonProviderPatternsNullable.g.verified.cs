﻿//HintName: G.JsonConverters.CodeSecurityConfigurationSecretScanningNonProviderPatternsNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeSecurityConfigurationSecretScanningNonProviderPatternsNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CodeSecurityConfigurationSecretScanningNonProviderPatterns?>
    {
        /// <inheritdoc />
        public override global::G.CodeSecurityConfigurationSecretScanningNonProviderPatterns? Read(
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
                        return global::G.CodeSecurityConfigurationSecretScanningNonProviderPatternsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CodeSecurityConfigurationSecretScanningNonProviderPatterns)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CodeSecurityConfigurationSecretScanningNonProviderPatterns?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CodeSecurityConfigurationSecretScanningNonProviderPatterns? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CodeSecurityConfigurationSecretScanningNonProviderPatternsExtensions.ToValueString(value.Value));
            }
        }
    }
}
