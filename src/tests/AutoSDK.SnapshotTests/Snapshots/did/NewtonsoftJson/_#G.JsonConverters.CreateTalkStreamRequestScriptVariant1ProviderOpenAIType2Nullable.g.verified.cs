//HintName: G.JsonConverters.CreateTalkStreamRequestScriptVariant1ProviderOpenAIType2Nullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTalkStreamRequestScriptVariant1ProviderOpenAIType2NullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateTalkStreamRequestScriptVariant1ProviderOpenAIType2?>
    {
        /// <inheritdoc />
        public override global::G.CreateTalkStreamRequestScriptVariant1ProviderOpenAIType2? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateTalkStreamRequestScriptVariant1ProviderOpenAIType2? existingValue,
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
                        return global::G.CreateTalkStreamRequestScriptVariant1ProviderOpenAIType2Extensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateTalkStreamRequestScriptVariant1ProviderOpenAIType2)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateTalkStreamRequestScriptVariant1ProviderOpenAIType2?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateTalkStreamRequestScriptVariant1ProviderOpenAIType2? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.CreateTalkStreamRequestScriptVariant1ProviderOpenAIType2Extensions.ToValueString(value.Value));
            }
        }
    }
}
