//HintName: G.JsonConverters.WebhooksRuleAllowDeletionsEnforcementLevel.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhooksRuleAllowDeletionsEnforcementLevelJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhooksRuleAllowDeletionsEnforcementLevel>
    {
        /// <inheritdoc />
        public override global::G.WebhooksRuleAllowDeletionsEnforcementLevel ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhooksRuleAllowDeletionsEnforcementLevel existingValue,
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
                        return global::G.WebhooksRuleAllowDeletionsEnforcementLevelExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhooksRuleAllowDeletionsEnforcementLevel)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhooksRuleAllowDeletionsEnforcementLevel);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhooksRuleAllowDeletionsEnforcementLevel value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhooksRuleAllowDeletionsEnforcementLevelExtensions.ToValueString(value));
        }
    }
}
