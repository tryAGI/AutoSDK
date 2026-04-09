//HintName: G.JsonConverters.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class KeysPostRequestBodyContentApplicationJsonSchemaLimitResetJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset>
    {
        /// <inheritdoc />
        public override global::G.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset existingValue,
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
                        return global::G.KeysPostRequestBodyContentApplicationJsonSchemaLimitResetExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.KeysPostRequestBodyContentApplicationJsonSchemaLimitReset value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.KeysPostRequestBodyContentApplicationJsonSchemaLimitResetExtensions.ToValueString(value));
        }
    }
}
