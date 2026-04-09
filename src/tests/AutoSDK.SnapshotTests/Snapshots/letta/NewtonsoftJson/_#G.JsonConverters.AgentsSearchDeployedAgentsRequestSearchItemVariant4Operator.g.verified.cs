//HintName: G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant4Operator.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentsSearchDeployedAgentsRequestSearchItemVariant4OperatorJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4Operator>
    {
        /// <inheritdoc />
        public override global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4Operator ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4Operator existingValue,
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
                        return global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4OperatorExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4Operator)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4Operator);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4Operator value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4OperatorExtensions.ToValueString(value));
        }
    }
}
