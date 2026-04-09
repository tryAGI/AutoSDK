//HintName: G.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId?>
    {
        /// <inheritdoc />
        public override global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId? existingValue,
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
                        return global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdExtensions.ToValueString(value.Value));
            }
        }
    }
}
