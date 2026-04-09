//HintName: G.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicAction.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutomationRuleEvaluatorObjectObjectPublicActionJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.AutomationRuleEvaluatorObjectObjectPublicAction>
    {
        /// <inheritdoc />
        public override global::G.AutomationRuleEvaluatorObjectObjectPublicAction ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.AutomationRuleEvaluatorObjectObjectPublicAction existingValue,
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
                        return global::G.AutomationRuleEvaluatorObjectObjectPublicActionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.AutomationRuleEvaluatorObjectObjectPublicAction)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.AutomationRuleEvaluatorObjectObjectPublicAction);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.AutomationRuleEvaluatorObjectObjectPublicAction value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.AutomationRuleEvaluatorObjectObjectPublicActionExtensions.ToValueString(value));
        }
    }
}
