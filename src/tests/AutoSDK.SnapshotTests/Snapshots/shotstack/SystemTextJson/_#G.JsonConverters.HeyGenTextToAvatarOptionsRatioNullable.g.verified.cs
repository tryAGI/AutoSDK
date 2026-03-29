//HintName: G.JsonConverters.HeyGenTextToAvatarOptionsRatioNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class HeyGenTextToAvatarOptionsRatioNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.HeyGenTextToAvatarOptionsRatio?>
    {
        /// <inheritdoc />
        public override global::G.HeyGenTextToAvatarOptionsRatio? Read(
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
                        return global::G.HeyGenTextToAvatarOptionsRatioExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.HeyGenTextToAvatarOptionsRatio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.HeyGenTextToAvatarOptionsRatio?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.HeyGenTextToAvatarOptionsRatio? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.HeyGenTextToAvatarOptionsRatioExtensions.ToValueString(value.Value));
            }
        }
    }
}
