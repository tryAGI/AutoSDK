//HintName: G.JsonConverters.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType existingValue,
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
                        return global::G.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.UpdateWebhookCredentialDTOAuthenticationPlanDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
