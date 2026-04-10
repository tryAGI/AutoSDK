//HintName: G.JsonConverters.HeyGenTextToAvatarOptionsAvatarStyle.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class HeyGenTextToAvatarOptionsAvatarStyleJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.HeyGenTextToAvatarOptionsAvatarStyle>
    {
        /// <inheritdoc />
        public override global::G.HeyGenTextToAvatarOptionsAvatarStyle ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.HeyGenTextToAvatarOptionsAvatarStyle existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.HeyGenTextToAvatarOptionsAvatarStyleExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.HeyGenTextToAvatarOptionsAvatarStyle)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.HeyGenTextToAvatarOptionsAvatarStyle);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.HeyGenTextToAvatarOptionsAvatarStyle value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.HeyGenTextToAvatarOptionsAvatarStyleExtensions.ToValueString(value));
        }
    }
}
