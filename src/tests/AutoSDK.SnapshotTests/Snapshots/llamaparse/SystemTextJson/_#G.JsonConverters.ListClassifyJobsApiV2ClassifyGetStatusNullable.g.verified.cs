//HintName: G.JsonConverters.ListClassifyJobsApiV2ClassifyGetStatusNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListClassifyJobsApiV2ClassifyGetStatusNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ListClassifyJobsApiV2ClassifyGetStatus?>
    {
        /// <inheritdoc />
        public override global::G.ListClassifyJobsApiV2ClassifyGetStatus? Read(
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
                        return global::G.ListClassifyJobsApiV2ClassifyGetStatusExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ListClassifyJobsApiV2ClassifyGetStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ListClassifyJobsApiV2ClassifyGetStatus?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ListClassifyJobsApiV2ClassifyGetStatus? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ListClassifyJobsApiV2ClassifyGetStatusExtensions.ToValueString(value.Value));
            }
        }
    }
}
