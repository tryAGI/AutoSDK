//HintName: G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant2Field.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentsSearchDeployedAgentsRequestSearchItemVariant2FieldJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant2Field>
    {
        /// <inheritdoc />
        public override global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant2Field ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant2Field existingValue,
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
                        return global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant2FieldExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant2Field)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant2Field);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant2Field value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant2FieldExtensions.ToValueString(value));
        }
    }
}
