//HintName: G.JsonConverters.MetadataSendFeedbackRequestFeatureNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MetadataSendFeedbackRequestFeatureNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.MetadataSendFeedbackRequestFeature?>
    {
        /// <inheritdoc />
        public override global::G.MetadataSendFeedbackRequestFeature? Read(
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
                        return global::G.MetadataSendFeedbackRequestFeatureExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.MetadataSendFeedbackRequestFeature)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.MetadataSendFeedbackRequestFeature?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.MetadataSendFeedbackRequestFeature? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.MetadataSendFeedbackRequestFeatureExtensions.ToValueString(value.Value));
            }
        }
    }
}
