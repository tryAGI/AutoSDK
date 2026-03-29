//HintName: G.JsonConverters.AcuvityScanParametersSecretsCategorieNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AcuvityScanParametersSecretsCategorieNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AcuvityScanParametersSecretsCategorie?>
    {
        /// <inheritdoc />
        public override global::G.AcuvityScanParametersSecretsCategorie? Read(
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
                        return global::G.AcuvityScanParametersSecretsCategorieExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.AcuvityScanParametersSecretsCategorie)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.AcuvityScanParametersSecretsCategorie?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AcuvityScanParametersSecretsCategorie? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.AcuvityScanParametersSecretsCategorieExtensions.ToValueString(value.Value));
            }
        }
    }
}
