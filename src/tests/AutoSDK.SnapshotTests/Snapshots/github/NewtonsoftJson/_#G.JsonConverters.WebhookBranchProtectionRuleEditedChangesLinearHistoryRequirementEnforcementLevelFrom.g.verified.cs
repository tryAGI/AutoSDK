//HintName: G.JsonConverters.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFromJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom>
    {
        /// <inheritdoc />
        public override global::G.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom existingValue,
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
                        return global::G.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFromExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFrom value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.WebhookBranchProtectionRuleEditedChangesLinearHistoryRequirementEnforcementLevelFromExtensions.ToValueString(value));
        }
    }
}
