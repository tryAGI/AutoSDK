//HintName: G.JsonConverters.UpdateTestCaseDefinitionResponseStatus2.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateTestCaseDefinitionResponseStatus2JsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.UpdateTestCaseDefinitionResponseStatus2>
    {
        /// <inheritdoc />
        public override global::G.UpdateTestCaseDefinitionResponseStatus2 ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.UpdateTestCaseDefinitionResponseStatus2 existingValue,
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
                        return global::G.UpdateTestCaseDefinitionResponseStatus2Extensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.UpdateTestCaseDefinitionResponseStatus2)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.UpdateTestCaseDefinitionResponseStatus2);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.UpdateTestCaseDefinitionResponseStatus2 value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.UpdateTestCaseDefinitionResponseStatus2Extensions.ToValueString(value));
        }
    }
}
