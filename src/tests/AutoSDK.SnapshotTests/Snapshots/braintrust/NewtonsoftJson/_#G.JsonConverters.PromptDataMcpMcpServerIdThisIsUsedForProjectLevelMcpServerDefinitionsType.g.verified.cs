//HintName: G.JsonConverters.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType>
    {
        /// <inheritdoc />
        public override global::G.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType existingValue,
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
                        return global::G.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PromptDataMcpMcpServerIdThisIsUsedForProjectLevelMcpServerDefinitionsTypeExtensions.ToValueString(value));
        }
    }
}
