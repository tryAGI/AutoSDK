//HintName: G.JsonConverters.ConfigurationResponseParametersDiscriminatorProductType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConfigurationResponseParametersDiscriminatorProductTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ConfigurationResponseParametersDiscriminatorProductType>
    {
        /// <inheritdoc />
        public override global::G.ConfigurationResponseParametersDiscriminatorProductType Read(
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
                        return global::G.ConfigurationResponseParametersDiscriminatorProductTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ConfigurationResponseParametersDiscriminatorProductType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ConfigurationResponseParametersDiscriminatorProductType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ConfigurationResponseParametersDiscriminatorProductType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ConfigurationResponseParametersDiscriminatorProductTypeExtensions.ToValueString(value));
        }
    }
}
