//HintName: G.JsonConverters.AgentsSearchDeployedAgentsRequestSearchItemVariant6FieldNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AgentsSearchDeployedAgentsRequestSearchItemVariant6FieldNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant6Field?>
    {
        /// <inheritdoc />
        public override global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant6Field? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant6Field? existingValue,
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
                        return global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant6FieldExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant6Field)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant6Field?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant6Field? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant6FieldExtensions.ToValueString(value.Value));
            }
        }
    }
}
