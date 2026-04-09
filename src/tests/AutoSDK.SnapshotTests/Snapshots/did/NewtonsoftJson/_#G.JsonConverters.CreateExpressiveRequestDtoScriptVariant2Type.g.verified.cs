//HintName: G.JsonConverters.CreateExpressiveRequestDtoScriptVariant2Type.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateExpressiveRequestDtoScriptVariant2TypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateExpressiveRequestDtoScriptVariant2Type>
    {
        /// <inheritdoc />
        public override global::G.CreateExpressiveRequestDtoScriptVariant2Type ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateExpressiveRequestDtoScriptVariant2Type existingValue,
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
                        return global::G.CreateExpressiveRequestDtoScriptVariant2TypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateExpressiveRequestDtoScriptVariant2Type)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateExpressiveRequestDtoScriptVariant2Type);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateExpressiveRequestDtoScriptVariant2Type value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateExpressiveRequestDtoScriptVariant2TypeExtensions.ToValueString(value));
        }
    }
}
