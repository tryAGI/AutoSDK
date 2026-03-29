//HintName: G.JsonConverters.OpenSwitchBotDevelopModeRequestCollaborationMode.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class OpenSwitchBotDevelopModeRequestCollaborationModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OpenSwitchBotDevelopModeRequestCollaborationMode>
    {
        /// <inheritdoc />
        public override global::G.OpenSwitchBotDevelopModeRequestCollaborationMode Read(
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
                        return global::G.OpenSwitchBotDevelopModeRequestCollaborationModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.OpenSwitchBotDevelopModeRequestCollaborationMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.OpenSwitchBotDevelopModeRequestCollaborationMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OpenSwitchBotDevelopModeRequestCollaborationMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.OpenSwitchBotDevelopModeRequestCollaborationModeExtensions.ToValueString(value));
        }
    }
}
