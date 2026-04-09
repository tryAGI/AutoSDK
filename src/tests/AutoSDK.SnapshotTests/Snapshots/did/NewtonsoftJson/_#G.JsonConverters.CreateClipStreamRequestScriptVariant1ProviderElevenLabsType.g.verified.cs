//HintName: G.JsonConverters.CreateClipStreamRequestScriptVariant1ProviderElevenLabsType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateClipStreamRequestScriptVariant1ProviderElevenLabsTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateClipStreamRequestScriptVariant1ProviderElevenLabsType>
    {
        /// <inheritdoc />
        public override global::G.CreateClipStreamRequestScriptVariant1ProviderElevenLabsType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateClipStreamRequestScriptVariant1ProviderElevenLabsType existingValue,
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
                        return global::G.CreateClipStreamRequestScriptVariant1ProviderElevenLabsTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateClipStreamRequestScriptVariant1ProviderElevenLabsType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateClipStreamRequestScriptVariant1ProviderElevenLabsType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateClipStreamRequestScriptVariant1ProviderElevenLabsType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateClipStreamRequestScriptVariant1ProviderElevenLabsTypeExtensions.ToValueString(value));
        }
    }
}
