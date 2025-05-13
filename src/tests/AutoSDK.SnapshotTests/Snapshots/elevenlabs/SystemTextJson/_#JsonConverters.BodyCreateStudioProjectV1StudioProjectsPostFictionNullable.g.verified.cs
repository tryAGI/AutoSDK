//HintName: JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostFictionNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyCreateStudioProjectV1StudioProjectsPostFictionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BodyCreateStudioProjectV1StudioProjectsPostFiction?>
    {
        /// <inheritdoc />
        public override global::G.BodyCreateStudioProjectV1StudioProjectsPostFiction? Read(
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
                        return global::G.BodyCreateStudioProjectV1StudioProjectsPostFictionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BodyCreateStudioProjectV1StudioProjectsPostFiction)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.BodyCreateStudioProjectV1StudioProjectsPostFiction?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BodyCreateStudioProjectV1StudioProjectsPostFiction? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.BodyCreateStudioProjectV1StudioProjectsPostFictionExtensions.ToValueString(value.Value));
            }
        }
    }
}
