//HintName: G.JsonConverters.CreateImageToVideoRequestVeo31FastRatioNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateImageToVideoRequestVeo31FastRatioNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateImageToVideoRequestVeo31FastRatio?>
    {
        /// <inheritdoc />
        public override global::G.CreateImageToVideoRequestVeo31FastRatio? Read(
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
                        return global::G.CreateImageToVideoRequestVeo31FastRatioExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateImageToVideoRequestVeo31FastRatio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateImageToVideoRequestVeo31FastRatio?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateImageToVideoRequestVeo31FastRatio? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.CreateImageToVideoRequestVeo31FastRatioExtensions.ToValueString(value.Value));
            }
        }
    }
}
