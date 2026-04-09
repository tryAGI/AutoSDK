//HintName: G.JsonConverters.CreateTalkRequestScriptVariant1ProviderGoogleType2.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTalkRequestScriptVariant1ProviderGoogleType2JsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateTalkRequestScriptVariant1ProviderGoogleType2>
    {
        /// <inheritdoc />
        public override global::G.CreateTalkRequestScriptVariant1ProviderGoogleType2 ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateTalkRequestScriptVariant1ProviderGoogleType2 existingValue,
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
                        return global::G.CreateTalkRequestScriptVariant1ProviderGoogleType2Extensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateTalkRequestScriptVariant1ProviderGoogleType2)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateTalkRequestScriptVariant1ProviderGoogleType2);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateTalkRequestScriptVariant1ProviderGoogleType2 value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateTalkRequestScriptVariant1ProviderGoogleType2Extensions.ToValueString(value));
        }
    }
}
