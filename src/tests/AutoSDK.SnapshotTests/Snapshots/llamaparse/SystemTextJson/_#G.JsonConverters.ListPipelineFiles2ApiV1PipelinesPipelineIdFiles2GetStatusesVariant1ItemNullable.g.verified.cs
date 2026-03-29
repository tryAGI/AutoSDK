//HintName: G.JsonConverters.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item?>
    {
        /// <inheritdoc />
        public override global::G.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item? Read(
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
                        return global::G.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1ItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
