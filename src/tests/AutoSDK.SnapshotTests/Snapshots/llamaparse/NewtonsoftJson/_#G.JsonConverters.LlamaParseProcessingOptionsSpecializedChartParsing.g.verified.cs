//HintName: G.JsonConverters.LlamaParseProcessingOptionsSpecializedChartParsing.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class LlamaParseProcessingOptionsSpecializedChartParsingJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.LlamaParseProcessingOptionsSpecializedChartParsing>
    {
        /// <inheritdoc />
        public override global::G.LlamaParseProcessingOptionsSpecializedChartParsing ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.LlamaParseProcessingOptionsSpecializedChartParsing existingValue,
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
                        return global::G.LlamaParseProcessingOptionsSpecializedChartParsingExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.LlamaParseProcessingOptionsSpecializedChartParsing)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.LlamaParseProcessingOptionsSpecializedChartParsing);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.LlamaParseProcessingOptionsSpecializedChartParsing value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.LlamaParseProcessingOptionsSpecializedChartParsingExtensions.ToValueString(value));
        }
    }
}
