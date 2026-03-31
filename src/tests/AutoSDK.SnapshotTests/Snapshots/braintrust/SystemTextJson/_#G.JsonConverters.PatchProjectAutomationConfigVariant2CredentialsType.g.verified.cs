//HintName: G.JsonConverters.PatchProjectAutomationConfigVariant2CredentialsType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchProjectAutomationConfigVariant2CredentialsTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PatchProjectAutomationConfigVariant2CredentialsType>
    {
        /// <inheritdoc />
        public override global::G.PatchProjectAutomationConfigVariant2CredentialsType Read(
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
                        return global::G.PatchProjectAutomationConfigVariant2CredentialsTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PatchProjectAutomationConfigVariant2CredentialsType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PatchProjectAutomationConfigVariant2CredentialsType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PatchProjectAutomationConfigVariant2CredentialsType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PatchProjectAutomationConfigVariant2CredentialsTypeExtensions.ToValueString(value));
        }
    }
}
