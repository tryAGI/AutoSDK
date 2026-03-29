//HintName: G.JsonConverters.LettaStreamingRequestInputVariant2ItemDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class LettaStreamingRequestInputVariant2ItemDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.LettaStreamingRequestInputVariant2ItemDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.LettaStreamingRequestInputVariant2ItemDiscriminatorType Read(
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
                        return global::G.LettaStreamingRequestInputVariant2ItemDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.LettaStreamingRequestInputVariant2ItemDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.LettaStreamingRequestInputVariant2ItemDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.LettaStreamingRequestInputVariant2ItemDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.LettaStreamingRequestInputVariant2ItemDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
