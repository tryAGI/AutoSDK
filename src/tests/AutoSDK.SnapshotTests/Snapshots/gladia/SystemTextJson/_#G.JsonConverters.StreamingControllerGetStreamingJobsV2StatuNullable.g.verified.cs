//HintName: G.JsonConverters.StreamingControllerGetStreamingJobsV2StatuNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class StreamingControllerGetStreamingJobsV2StatuNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.StreamingControllerGetStreamingJobsV2Statu?>
    {
        /// <inheritdoc />
        public override global::G.StreamingControllerGetStreamingJobsV2Statu? Read(
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
                        return global::G.StreamingControllerGetStreamingJobsV2StatuExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.StreamingControllerGetStreamingJobsV2Statu)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.StreamingControllerGetStreamingJobsV2Statu?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.StreamingControllerGetStreamingJobsV2Statu? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.StreamingControllerGetStreamingJobsV2StatuExtensions.ToValueString(value.Value));
            }
        }
    }
}
