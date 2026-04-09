//HintName: G.JsonConverters.AutomationRuleEvaluatorObjectObjectPublicType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AutomationRuleEvaluatorObjectObjectPublicTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.AutomationRuleEvaluatorObjectObjectPublicType>
    {
        /// <inheritdoc />
        public override global::G.AutomationRuleEvaluatorObjectObjectPublicType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.AutomationRuleEvaluatorObjectObjectPublicType existingValue,
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
                        return global::G.AutomationRuleEvaluatorObjectObjectPublicTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.AutomationRuleEvaluatorObjectObjectPublicType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.AutomationRuleEvaluatorObjectObjectPublicType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.AutomationRuleEvaluatorObjectObjectPublicType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.AutomationRuleEvaluatorObjectObjectPublicTypeExtensions.ToValueString(value));
        }
    }
}
