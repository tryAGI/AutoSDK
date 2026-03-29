//HintName: G.JsonConverters.ChatRequestPluginsItemsOneOf0Id.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatRequestPluginsItemsOneOf0IdJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ChatRequestPluginsItemsOneOf0Id>
    {
        /// <inheritdoc />
        public override global::G.ChatRequestPluginsItemsOneOf0Id Read(
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
                        return global::G.ChatRequestPluginsItemsOneOf0IdExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ChatRequestPluginsItemsOneOf0Id)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ChatRequestPluginsItemsOneOf0Id);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ChatRequestPluginsItemsOneOf0Id value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ChatRequestPluginsItemsOneOf0IdExtensions.ToValueString(value));
        }
    }
}
