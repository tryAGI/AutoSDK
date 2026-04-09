//HintName: G.JsonConverters.Create2RequestScriptTextProviderAmazonVoiceIdNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class Create2RequestScriptTextProviderAmazonVoiceIdNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.Create2RequestScriptTextProviderAmazonVoiceId?>
    {
        /// <inheritdoc />
        public override global::G.Create2RequestScriptTextProviderAmazonVoiceId? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.Create2RequestScriptTextProviderAmazonVoiceId? existingValue,
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
                        return global::G.Create2RequestScriptTextProviderAmazonVoiceIdExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.Create2RequestScriptTextProviderAmazonVoiceId)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.Create2RequestScriptTextProviderAmazonVoiceId?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.Create2RequestScriptTextProviderAmazonVoiceId? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.Create2RequestScriptTextProviderAmazonVoiceIdExtensions.ToValueString(value.Value));
            }
        }
    }
}
