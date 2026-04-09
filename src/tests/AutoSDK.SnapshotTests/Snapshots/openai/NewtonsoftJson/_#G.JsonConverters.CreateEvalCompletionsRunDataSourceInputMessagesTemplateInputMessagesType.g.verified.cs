//HintName: G.JsonConverters.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType>
    {
        /// <inheritdoc />
        public override global::G.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType existingValue,
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
                        return global::G.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateEvalCompletionsRunDataSourceInputMessagesTemplateInputMessagesTypeExtensions.ToValueString(value));
        }
    }
}
