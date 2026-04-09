//HintName: G.JsonConverters.HeyGenTextToAvatarOptionsAvatar.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class HeyGenTextToAvatarOptionsAvatarJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.HeyGenTextToAvatarOptionsAvatar>
    {
        /// <inheritdoc />
        public override global::G.HeyGenTextToAvatarOptionsAvatar ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.HeyGenTextToAvatarOptionsAvatar existingValue,
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
                        return global::G.HeyGenTextToAvatarOptionsAvatarExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.HeyGenTextToAvatarOptionsAvatar)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.HeyGenTextToAvatarOptionsAvatar);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.HeyGenTextToAvatarOptionsAvatar value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.HeyGenTextToAvatarOptionsAvatarExtensions.ToValueString(value));
        }
    }
}
