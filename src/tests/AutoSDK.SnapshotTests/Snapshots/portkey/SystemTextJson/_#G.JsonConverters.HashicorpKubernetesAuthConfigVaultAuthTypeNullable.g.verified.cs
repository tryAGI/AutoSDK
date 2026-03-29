//HintName: G.JsonConverters.HashicorpKubernetesAuthConfigVaultAuthTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class HashicorpKubernetesAuthConfigVaultAuthTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.HashicorpKubernetesAuthConfigVaultAuthType?>
    {
        /// <inheritdoc />
        public override global::G.HashicorpKubernetesAuthConfigVaultAuthType? Read(
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
                        return global::G.HashicorpKubernetesAuthConfigVaultAuthTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.HashicorpKubernetesAuthConfigVaultAuthType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.HashicorpKubernetesAuthConfigVaultAuthType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.HashicorpKubernetesAuthConfigVaultAuthType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.HashicorpKubernetesAuthConfigVaultAuthTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
