//HintName: G.JsonConverters.SmsFailedEdgeVariant2TransitionConditionPrompt.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SmsFailedEdgeVariant2TransitionConditionPromptJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.SmsFailedEdgeVariant2TransitionConditionPrompt>
    {
        /// <inheritdoc />
        public override global::G.SmsFailedEdgeVariant2TransitionConditionPrompt ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.SmsFailedEdgeVariant2TransitionConditionPrompt existingValue,
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
                        return global::G.SmsFailedEdgeVariant2TransitionConditionPromptExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.SmsFailedEdgeVariant2TransitionConditionPrompt)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.SmsFailedEdgeVariant2TransitionConditionPrompt);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.SmsFailedEdgeVariant2TransitionConditionPrompt value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.SmsFailedEdgeVariant2TransitionConditionPromptExtensions.ToValueString(value));
        }
    }
}
