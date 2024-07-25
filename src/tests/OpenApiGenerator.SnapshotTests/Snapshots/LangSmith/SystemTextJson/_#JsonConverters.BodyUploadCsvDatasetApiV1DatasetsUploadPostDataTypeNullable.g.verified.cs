//HintName: JsonConverters.BodyUploadCsvDatasetApiV1DatasetsUploadPostDataTypeNullable.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyUploadCsvDatasetApiV1DatasetsUploadPostDataTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BodyUploadCsvDatasetApiV1DatasetsUploadPostDataType?>
    {
        /// <inheritdoc />
        public override global::G.BodyUploadCsvDatasetApiV1DatasetsUploadPostDataType? Read(
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
                        return global::G.BodyUploadCsvDatasetApiV1DatasetsUploadPostDataTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BodyUploadCsvDatasetApiV1DatasetsUploadPostDataType)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BodyUploadCsvDatasetApiV1DatasetsUploadPostDataType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.BodyUploadCsvDatasetApiV1DatasetsUploadPostDataTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
