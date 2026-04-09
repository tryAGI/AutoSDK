//HintName: G.JsonConverters.CreateExpressiveRequestDtoScriptVariant1ProviderGoogleTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateExpressiveRequestDtoScriptVariant1ProviderGoogleTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateExpressiveRequestDtoScriptVariant1ProviderGoogleType?>
    {
        /// <inheritdoc />
        public override global::G.CreateExpressiveRequestDtoScriptVariant1ProviderGoogleType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateExpressiveRequestDtoScriptVariant1ProviderGoogleType? existingValue,
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
                        return global::G.CreateExpressiveRequestDtoScriptVariant1ProviderGoogleTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateExpressiveRequestDtoScriptVariant1ProviderGoogleType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateExpressiveRequestDtoScriptVariant1ProviderGoogleType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateExpressiveRequestDtoScriptVariant1ProviderGoogleType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.CreateExpressiveRequestDtoScriptVariant1ProviderGoogleTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
