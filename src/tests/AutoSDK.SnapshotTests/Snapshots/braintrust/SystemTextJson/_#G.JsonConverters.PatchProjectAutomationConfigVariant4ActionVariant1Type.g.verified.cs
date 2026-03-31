//HintName: G.JsonConverters.PatchProjectAutomationConfigVariant4ActionVariant1Type.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchProjectAutomationConfigVariant4ActionVariant1TypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PatchProjectAutomationConfigVariant4ActionVariant1Type>
    {
        /// <inheritdoc />
        public override global::G.PatchProjectAutomationConfigVariant4ActionVariant1Type Read(
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
                        return global::G.PatchProjectAutomationConfigVariant4ActionVariant1TypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PatchProjectAutomationConfigVariant4ActionVariant1Type)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PatchProjectAutomationConfigVariant4ActionVariant1Type);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PatchProjectAutomationConfigVariant4ActionVariant1Type value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PatchProjectAutomationConfigVariant4ActionVariant1TypeExtensions.ToValueString(value));
        }
    }
}
