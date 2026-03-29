//HintName: G.JsonConverters.FeedbackScoreExperimentItemBulkWriteViewSource.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FeedbackScoreExperimentItemBulkWriteViewSourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FeedbackScoreExperimentItemBulkWriteViewSource>
    {
        /// <inheritdoc />
        public override global::G.FeedbackScoreExperimentItemBulkWriteViewSource Read(
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
                        return global::G.FeedbackScoreExperimentItemBulkWriteViewSourceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.FeedbackScoreExperimentItemBulkWriteViewSource)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.FeedbackScoreExperimentItemBulkWriteViewSource);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FeedbackScoreExperimentItemBulkWriteViewSource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.FeedbackScoreExperimentItemBulkWriteViewSourceExtensions.ToValueString(value));
        }
    }
}
