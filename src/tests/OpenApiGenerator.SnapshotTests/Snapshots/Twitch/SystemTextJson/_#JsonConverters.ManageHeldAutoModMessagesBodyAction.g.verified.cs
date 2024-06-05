//HintName: JsonConverters.ManageHeldAutoModMessagesBodyAction.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ManageHeldAutoModMessagesBodyActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ManageHeldAutoModMessagesBodyAction>
    {
        /// <inheritdoc />
        public override global::G.ManageHeldAutoModMessagesBodyAction Read(
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
                        return global::G.ManageHeldAutoModMessagesBodyActionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ManageHeldAutoModMessagesBodyAction)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ManageHeldAutoModMessagesBodyAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ManageHeldAutoModMessagesBodyActionExtensions.ToValueString(value));
        }
    }
}
