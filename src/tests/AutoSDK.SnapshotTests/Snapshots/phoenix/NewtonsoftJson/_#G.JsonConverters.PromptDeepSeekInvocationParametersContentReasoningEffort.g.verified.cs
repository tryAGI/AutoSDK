//HintName: G.JsonConverters.PromptDeepSeekInvocationParametersContentReasoningEffort.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PromptDeepSeekInvocationParametersContentReasoningEffortJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PromptDeepSeekInvocationParametersContentReasoningEffort>
    {
        /// <inheritdoc />
        public override global::G.PromptDeepSeekInvocationParametersContentReasoningEffort ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PromptDeepSeekInvocationParametersContentReasoningEffort existingValue,
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
                        return global::G.PromptDeepSeekInvocationParametersContentReasoningEffortExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PromptDeepSeekInvocationParametersContentReasoningEffort)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PromptDeepSeekInvocationParametersContentReasoningEffort);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PromptDeepSeekInvocationParametersContentReasoningEffort value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PromptDeepSeekInvocationParametersContentReasoningEffortExtensions.ToValueString(value));
        }
    }
}
