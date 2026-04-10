//HintName: G.JsonConverters.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProviderJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider>
    {
        /// <inheritdoc />
        public override global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider existingValue,
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
                        return global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProviderExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProvider value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateGoogleSheetsOAuth2AuthorizationCredentialDTOProviderExtensions.ToValueString(value));
        }
    }
}
