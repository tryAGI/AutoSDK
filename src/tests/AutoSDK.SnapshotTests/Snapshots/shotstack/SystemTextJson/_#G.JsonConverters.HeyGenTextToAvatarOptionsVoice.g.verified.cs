//HintName: G.JsonConverters.HeyGenTextToAvatarOptionsVoice.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class HeyGenTextToAvatarOptionsVoiceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.HeyGenTextToAvatarOptionsVoice>
    {
        /// <inheritdoc />
        public override global::G.HeyGenTextToAvatarOptionsVoice Read(
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
                        return global::G.HeyGenTextToAvatarOptionsVoiceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.HeyGenTextToAvatarOptionsVoice)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.HeyGenTextToAvatarOptionsVoice);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.HeyGenTextToAvatarOptionsVoice value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.HeyGenTextToAvatarOptionsVoiceExtensions.ToValueString(value));
        }
    }
}
