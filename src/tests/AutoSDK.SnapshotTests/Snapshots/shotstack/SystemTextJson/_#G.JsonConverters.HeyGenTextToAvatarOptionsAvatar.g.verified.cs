//HintName: G.JsonConverters.HeyGenTextToAvatarOptionsAvatar.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class HeyGenTextToAvatarOptionsAvatarJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.HeyGenTextToAvatarOptionsAvatar>
    {
        /// <inheritdoc />
        public override global::G.HeyGenTextToAvatarOptionsAvatar Read(
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
                        return global::G.HeyGenTextToAvatarOptionsAvatarExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.HeyGenTextToAvatarOptionsAvatar)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.HeyGenTextToAvatarOptionsAvatar);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.HeyGenTextToAvatarOptionsAvatar value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.HeyGenTextToAvatarOptionsAvatarExtensions.ToValueString(value));
        }
    }
}
