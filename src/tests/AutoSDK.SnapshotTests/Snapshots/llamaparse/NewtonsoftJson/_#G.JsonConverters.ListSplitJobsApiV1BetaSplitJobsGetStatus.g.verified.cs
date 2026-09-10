//HintName: G.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatus.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListSplitJobsApiV1BetaSplitJobsGetStatusJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus>
    {
        /// <inheritdoc />
        public override global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.ListSplitJobsApiV1BetaSplitJobsGetStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ListSplitJobsApiV1BetaSplitJobsGetStatusExtensions.ToValueString(value));
        }
    }
}
