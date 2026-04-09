//HintName: G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant4FieldNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentsSearchDeployedAgentsRequestSearchItemVariant4FieldNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4Field?>
    {
        /// <inheritdoc />
        public override global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4Field? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4Field? existingValue,
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
                        return global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4FieldExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4Field)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4Field?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4Field? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4FieldExtensions.ToValueString(value.Value));
            }
        }
    }
}
