//HintName: G.JsonConverters.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType>
    {
        /// <inheritdoc />
        public override global::G.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType existingValue,
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
                        return global::G.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateExpressiveRequestDtoScriptVariant1ProviderMicrosoftTypeExtensions.ToValueString(value));
        }
    }
}
