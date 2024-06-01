//HintName: JsonConverters.ReposCreateOrgRulesetRequestEnforcement.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReposCreateOrgRulesetRequestEnforcementJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReposCreateOrgRulesetRequestEnforcement>
    {
        /// <inheritdoc />
        public override global::G.ReposCreateOrgRulesetRequestEnforcement Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.ReposCreateOrgRulesetRequestEnforcementExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ReposCreateOrgRulesetRequestEnforcement)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReposCreateOrgRulesetRequestEnforcement value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.ReposCreateOrgRulesetRequestEnforcementExtensions.ToValueString(value));
        }
    }
}
