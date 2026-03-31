//HintName: G.JsonConverters.CreateTalkStreamRequestConfigVariant1ResultFormat2.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTalkStreamRequestConfigVariant1ResultFormat2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateTalkStreamRequestConfigVariant1ResultFormat2>
    {
        /// <inheritdoc />
        public override global::G.CreateTalkStreamRequestConfigVariant1ResultFormat2 Read(
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
                        return global::G.CreateTalkStreamRequestConfigVariant1ResultFormat2Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateTalkStreamRequestConfigVariant1ResultFormat2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateTalkStreamRequestConfigVariant1ResultFormat2);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateTalkStreamRequestConfigVariant1ResultFormat2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.CreateTalkStreamRequestConfigVariant1ResultFormat2Extensions.ToValueString(value));
        }
    }
}
