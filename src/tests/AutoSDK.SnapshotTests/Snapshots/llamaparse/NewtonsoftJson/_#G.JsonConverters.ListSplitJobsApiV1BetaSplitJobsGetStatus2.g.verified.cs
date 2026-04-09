//HintName: G.JsonConverters.ListSplitJobsApiV1BetaSplitJobsGetStatus2.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListSplitJobsApiV1BetaSplitJobsGetStatus2JsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus2>
    {
        /// <inheritdoc />
        public override global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus2 ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus2 existingValue,
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
                        return global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus2Extensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus2)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus2);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus2 value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ListSplitJobsApiV1BetaSplitJobsGetStatus2Extensions.ToValueString(value));
        }
    }
}
