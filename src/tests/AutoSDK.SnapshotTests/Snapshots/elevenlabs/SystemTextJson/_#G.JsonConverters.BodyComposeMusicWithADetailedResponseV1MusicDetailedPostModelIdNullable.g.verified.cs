//HintName: G.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId?>
    {
        /// <inheritdoc />
        public override global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId? Read(
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
                        return global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelId? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelIdExtensions.ToValueString(value.Value));
            }
        }
    }
}
