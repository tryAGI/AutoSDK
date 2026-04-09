//HintName: G.JsonConverters.JSONQueryOnCallTableWithStructuredOutputColumnOperation.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class JSONQueryOnCallTableWithStructuredOutputColumnOperationJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.JSONQueryOnCallTableWithStructuredOutputColumnOperation>
    {
        /// <inheritdoc />
        public override global::G.JSONQueryOnCallTableWithStructuredOutputColumnOperation ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.JSONQueryOnCallTableWithStructuredOutputColumnOperation existingValue,
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
                        return global::G.JSONQueryOnCallTableWithStructuredOutputColumnOperationExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.JSONQueryOnCallTableWithStructuredOutputColumnOperation)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.JSONQueryOnCallTableWithStructuredOutputColumnOperation);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.JSONQueryOnCallTableWithStructuredOutputColumnOperation value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.JSONQueryOnCallTableWithStructuredOutputColumnOperationExtensions.ToValueString(value));
        }
    }
}
