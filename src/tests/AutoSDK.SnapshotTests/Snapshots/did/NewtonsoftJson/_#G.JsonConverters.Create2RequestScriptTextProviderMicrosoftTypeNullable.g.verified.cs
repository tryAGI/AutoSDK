//HintName: G.JsonConverters.Create2RequestScriptTextProviderMicrosoftTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class Create2RequestScriptTextProviderMicrosoftTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.Create2RequestScriptTextProviderMicrosoftType?>
    {
        /// <inheritdoc />
        public override global::G.Create2RequestScriptTextProviderMicrosoftType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.Create2RequestScriptTextProviderMicrosoftType? existingValue,
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
                        return global::G.Create2RequestScriptTextProviderMicrosoftTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.Create2RequestScriptTextProviderMicrosoftType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.Create2RequestScriptTextProviderMicrosoftType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.Create2RequestScriptTextProviderMicrosoftType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.Create2RequestScriptTextProviderMicrosoftTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
