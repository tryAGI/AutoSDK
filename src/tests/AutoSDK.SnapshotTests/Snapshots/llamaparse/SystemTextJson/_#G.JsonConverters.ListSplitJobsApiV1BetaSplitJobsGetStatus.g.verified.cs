//HintName: G.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatus.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListSplitJobsApiV1BetaSplitJobsGetStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus>
    {
        /// <inheritdoc />
        public override global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus Read(
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
                        return global::G.ListSplitJobsApiV1BetaSplitJobsGetStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ListSplitJobsApiV1BetaSplitJobsGetStatusExtensions.ToValueString(value));
        }
    }
}
