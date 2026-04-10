//HintName: G.JsonConverters.PromptCerebrasInvocationParametersContentReasoningEffortNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PromptCerebrasInvocationParametersContentReasoningEffortNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PromptCerebrasInvocationParametersContentReasoningEffort?>
    {
        /// <inheritdoc />
        public override global::G.PromptCerebrasInvocationParametersContentReasoningEffort? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PromptCerebrasInvocationParametersContentReasoningEffort? existingValue,
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
                        return global::G.PromptCerebrasInvocationParametersContentReasoningEffortExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PromptCerebrasInvocationParametersContentReasoningEffort)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PromptCerebrasInvocationParametersContentReasoningEffort?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PromptCerebrasInvocationParametersContentReasoningEffort? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.PromptCerebrasInvocationParametersContentReasoningEffortExtensions.ToValueString(value.Value));
            }
        }
    }
}
