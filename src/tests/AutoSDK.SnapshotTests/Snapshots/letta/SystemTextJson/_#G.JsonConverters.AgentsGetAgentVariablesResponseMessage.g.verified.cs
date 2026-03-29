//HintName: G.JsonConverters.AgentsGetAgentVariablesResponseMessage.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentsGetAgentVariablesResponseMessageJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AgentsGetAgentVariablesResponseMessage>
    {
        /// <inheritdoc />
        public override global::G.AgentsGetAgentVariablesResponseMessage Read(
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
                        return global::G.AgentsGetAgentVariablesResponseMessageExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.AgentsGetAgentVariablesResponseMessage)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.AgentsGetAgentVariablesResponseMessage);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AgentsGetAgentVariablesResponseMessage value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.AgentsGetAgentVariablesResponseMessageExtensions.ToValueString(value));
        }
    }
}
