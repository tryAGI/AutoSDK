//HintName: G.JsonConverters.CreateTalkStreamRequestScriptVariant1Type2.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTalkStreamRequestScriptVariant1Type2JsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateTalkStreamRequestScriptVariant1Type2>
    {
        /// <inheritdoc />
        public override global::G.CreateTalkStreamRequestScriptVariant1Type2 ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateTalkStreamRequestScriptVariant1Type2 existingValue,
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
                        return global::G.CreateTalkStreamRequestScriptVariant1Type2Extensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateTalkStreamRequestScriptVariant1Type2)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateTalkStreamRequestScriptVariant1Type2);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateTalkStreamRequestScriptVariant1Type2 value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateTalkStreamRequestScriptVariant1Type2Extensions.ToValueString(value));
        }
    }
}
