//HintName: G.JsonConverters.CreateTalkRequestScriptVariant1ProviderOpenAIType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTalkRequestScriptVariant1ProviderOpenAITypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateTalkRequestScriptVariant1ProviderOpenAIType>
    {
        /// <inheritdoc />
        public override global::G.CreateTalkRequestScriptVariant1ProviderOpenAIType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateTalkRequestScriptVariant1ProviderOpenAIType existingValue,
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
                        return global::G.CreateTalkRequestScriptVariant1ProviderOpenAITypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateTalkRequestScriptVariant1ProviderOpenAIType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateTalkRequestScriptVariant1ProviderOpenAIType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateTalkRequestScriptVariant1ProviderOpenAIType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateTalkRequestScriptVariant1ProviderOpenAITypeExtensions.ToValueString(value));
        }
    }
}
