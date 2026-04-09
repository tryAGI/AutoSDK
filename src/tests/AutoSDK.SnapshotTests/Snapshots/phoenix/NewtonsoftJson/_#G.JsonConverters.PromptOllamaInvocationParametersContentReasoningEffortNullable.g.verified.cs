//HintName: G.JsonConverters.PromptOllamaInvocationParametersContentReasoningEffortNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PromptOllamaInvocationParametersContentReasoningEffortNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PromptOllamaInvocationParametersContentReasoningEffort?>
    {
        /// <inheritdoc />
        public override global::G.PromptOllamaInvocationParametersContentReasoningEffort? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PromptOllamaInvocationParametersContentReasoningEffort? existingValue,
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
                        return global::G.PromptOllamaInvocationParametersContentReasoningEffortExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PromptOllamaInvocationParametersContentReasoningEffort)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PromptOllamaInvocationParametersContentReasoningEffort?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PromptOllamaInvocationParametersContentReasoningEffort? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.PromptOllamaInvocationParametersContentReasoningEffortExtensions.ToValueString(value.Value));
            }
        }
    }
}
