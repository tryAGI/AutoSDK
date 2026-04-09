//HintName: G.JsonConverters.OpenAiResponsesToolChoiceOneOf4Type1Nullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class OpenAiResponsesToolChoiceOneOf4Type1NullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.OpenAiResponsesToolChoiceOneOf4Type1?>
    {
        /// <inheritdoc />
        public override global::G.OpenAiResponsesToolChoiceOneOf4Type1? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.OpenAiResponsesToolChoiceOneOf4Type1? existingValue,
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
                        return global::G.OpenAiResponsesToolChoiceOneOf4Type1Extensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.OpenAiResponsesToolChoiceOneOf4Type1)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.OpenAiResponsesToolChoiceOneOf4Type1?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.OpenAiResponsesToolChoiceOneOf4Type1? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.OpenAiResponsesToolChoiceOneOf4Type1Extensions.ToValueString(value.Value));
            }
        }
    }
}
