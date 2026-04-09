//HintName: G.JsonConverters.DependabotListAlertsForEnterpriseScope.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class DependabotListAlertsForEnterpriseScopeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.DependabotListAlertsForEnterpriseScope>
    {
        /// <inheritdoc />
        public override global::G.DependabotListAlertsForEnterpriseScope ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.DependabotListAlertsForEnterpriseScope existingValue,
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
                        return global::G.DependabotListAlertsForEnterpriseScopeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.DependabotListAlertsForEnterpriseScope)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.DependabotListAlertsForEnterpriseScope);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.DependabotListAlertsForEnterpriseScope value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.DependabotListAlertsForEnterpriseScopeExtensions.ToValueString(value));
        }
    }
}
