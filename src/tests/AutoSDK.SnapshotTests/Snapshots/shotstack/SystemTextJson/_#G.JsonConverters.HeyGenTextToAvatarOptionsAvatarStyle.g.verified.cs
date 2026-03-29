//HintName: G.JsonConverters.HeyGenTextToAvatarOptionsAvatarStyle.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class HeyGenTextToAvatarOptionsAvatarStyleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.HeyGenTextToAvatarOptionsAvatarStyle>
    {
        /// <inheritdoc />
        public override global::G.HeyGenTextToAvatarOptionsAvatarStyle Read(
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
                        return global::G.HeyGenTextToAvatarOptionsAvatarStyleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.HeyGenTextToAvatarOptionsAvatarStyle)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.HeyGenTextToAvatarOptionsAvatarStyle);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.HeyGenTextToAvatarOptionsAvatarStyle value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.HeyGenTextToAvatarOptionsAvatarStyleExtensions.ToValueString(value));
        }
    }
}
