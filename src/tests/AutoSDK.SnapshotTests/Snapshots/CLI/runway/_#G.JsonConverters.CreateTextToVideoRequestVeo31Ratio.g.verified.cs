//HintName: G.JsonConverters.CreateTextToVideoRequestVeo31Ratio.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTextToVideoRequestVeo31RatioJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CreateTextToVideoRequestVeo31Ratio>
    {
        /// <inheritdoc />
        public override global::G.CreateTextToVideoRequestVeo31Ratio Read(
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
                        return global::G.CreateTextToVideoRequestVeo31RatioExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CreateTextToVideoRequestVeo31Ratio)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CreateTextToVideoRequestVeo31Ratio);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CreateTextToVideoRequestVeo31Ratio value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.CreateTextToVideoRequestVeo31RatioExtensions.ToValueString(value));
        }
    }
}
