//HintName: G.JsonConverters.SpanExperimentItemBulkWriteViewType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SpanExperimentItemBulkWriteViewTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SpanExperimentItemBulkWriteViewType>
    {
        /// <inheritdoc />
        public override global::G.SpanExperimentItemBulkWriteViewType Read(
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
                        return global::G.SpanExperimentItemBulkWriteViewTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.SpanExperimentItemBulkWriteViewType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.SpanExperimentItemBulkWriteViewType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SpanExperimentItemBulkWriteViewType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.SpanExperimentItemBulkWriteViewTypeExtensions.ToValueString(value));
        }
    }
}
