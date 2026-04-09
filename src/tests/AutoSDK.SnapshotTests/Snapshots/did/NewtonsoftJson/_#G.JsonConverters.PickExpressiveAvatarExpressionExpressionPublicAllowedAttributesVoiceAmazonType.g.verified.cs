//HintName: G.JsonConverters.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonType>
    {
        /// <inheritdoc />
        public override global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonType existingValue,
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
                        return global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PickExpressiveAvatarExpressionExpressionPublicAllowedAttributesVoiceAmazonTypeExtensions.ToValueString(value));
        }
    }
}
