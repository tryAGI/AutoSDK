//HintName: G.JsonConverters.CreateVideoToVideoRequestGen4AlephRatioNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateVideoToVideoRequestGen4AlephRatioNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateVideoToVideoRequestGen4AlephRatio?>
    {
        /// <inheritdoc />
        public override global::G.CreateVideoToVideoRequestGen4AlephRatio? Read(
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
                        return global::G.CreateVideoToVideoRequestGen4AlephRatioExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateVideoToVideoRequestGen4AlephRatio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateVideoToVideoRequestGen4AlephRatio?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateVideoToVideoRequestGen4AlephRatio? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CreateVideoToVideoRequestGen4AlephRatioExtensions.ToValueString(value.Value));
            }
        }
    }
}
