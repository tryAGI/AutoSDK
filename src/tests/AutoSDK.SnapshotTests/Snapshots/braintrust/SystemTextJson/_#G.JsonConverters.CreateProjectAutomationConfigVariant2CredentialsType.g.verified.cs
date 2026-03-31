//HintName: G.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateProjectAutomationConfigVariant2CredentialsTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateProjectAutomationConfigVariant2CredentialsType>
    {
        /// <inheritdoc />
        public override global::G.CreateProjectAutomationConfigVariant2CredentialsType Read(
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
                        return global::G.CreateProjectAutomationConfigVariant2CredentialsTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateProjectAutomationConfigVariant2CredentialsType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateProjectAutomationConfigVariant2CredentialsType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateProjectAutomationConfigVariant2CredentialsType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.CreateProjectAutomationConfigVariant2CredentialsTypeExtensions.ToValueString(value));
        }
    }
}
