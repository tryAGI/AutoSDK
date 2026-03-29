//HintName: G.JsonConverters.AzureEntraAuthConfigAzureAuthMode.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AzureEntraAuthConfigAzureAuthModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AzureEntraAuthConfigAzureAuthMode>
    {
        /// <inheritdoc />
        public override global::G.AzureEntraAuthConfigAzureAuthMode Read(
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
                        return global::G.AzureEntraAuthConfigAzureAuthModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.AzureEntraAuthConfigAzureAuthMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.AzureEntraAuthConfigAzureAuthMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AzureEntraAuthConfigAzureAuthMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.AzureEntraAuthConfigAzureAuthModeExtensions.ToValueString(value));
        }
    }
}
