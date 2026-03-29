//HintName: G.JsonConverters.PublicKeyEncryptionPlanAlgorithmNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PublicKeyEncryptionPlanAlgorithmNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PublicKeyEncryptionPlanAlgorithm?>
    {
        /// <inheritdoc />
        public override global::G.PublicKeyEncryptionPlanAlgorithm? Read(
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
                        return global::G.PublicKeyEncryptionPlanAlgorithmExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PublicKeyEncryptionPlanAlgorithm)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PublicKeyEncryptionPlanAlgorithm?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PublicKeyEncryptionPlanAlgorithm? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.PublicKeyEncryptionPlanAlgorithmExtensions.ToValueString(value.Value));
            }
        }
    }
}
