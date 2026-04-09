//HintName: G.JsonConverters.StreamScriptVariant1ProviderElevenLabsType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class StreamScriptVariant1ProviderElevenLabsTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.StreamScriptVariant1ProviderElevenLabsType>
    {
        /// <inheritdoc />
        public override global::G.StreamScriptVariant1ProviderElevenLabsType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.StreamScriptVariant1ProviderElevenLabsType existingValue,
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
                        return global::G.StreamScriptVariant1ProviderElevenLabsTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.StreamScriptVariant1ProviderElevenLabsType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.StreamScriptVariant1ProviderElevenLabsType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.StreamScriptVariant1ProviderElevenLabsType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.StreamScriptVariant1ProviderElevenLabsTypeExtensions.ToValueString(value));
        }
    }
}
