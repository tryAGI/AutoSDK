//HintName: G.JsonConverters.AgentPresenterExpressiveAvatarVoiceMicrosoftType2Nullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentPresenterExpressiveAvatarVoiceMicrosoftType2NullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.AgentPresenterExpressiveAvatarVoiceMicrosoftType2?>
    {
        /// <inheritdoc />
        public override global::G.AgentPresenterExpressiveAvatarVoiceMicrosoftType2? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.AgentPresenterExpressiveAvatarVoiceMicrosoftType2? existingValue,
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
                        return global::G.AgentPresenterExpressiveAvatarVoiceMicrosoftType2Extensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.AgentPresenterExpressiveAvatarVoiceMicrosoftType2)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.AgentPresenterExpressiveAvatarVoiceMicrosoftType2?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.AgentPresenterExpressiveAvatarVoiceMicrosoftType2? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.AgentPresenterExpressiveAvatarVoiceMicrosoftType2Extensions.ToValueString(value.Value));
            }
        }
    }
}
