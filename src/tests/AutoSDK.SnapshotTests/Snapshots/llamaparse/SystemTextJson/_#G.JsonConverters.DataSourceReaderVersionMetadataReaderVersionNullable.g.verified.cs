//HintName: G.JsonConverters.DataSourceReaderVersionMetadataReaderVersionNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class DataSourceReaderVersionMetadataReaderVersionNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.DataSourceReaderVersionMetadataReaderVersion?>
    {
        /// <inheritdoc />
        public override global::G.DataSourceReaderVersionMetadataReaderVersion? Read(
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
                        return global::G.DataSourceReaderVersionMetadataReaderVersionExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.DataSourceReaderVersionMetadataReaderVersion)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.DataSourceReaderVersionMetadataReaderVersion?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.DataSourceReaderVersionMetadataReaderVersion? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.DataSourceReaderVersionMetadataReaderVersionExtensions.ToValueString(value.Value));
            }
        }
    }
}
