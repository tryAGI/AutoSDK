//HintName: G.JsonConverters.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType>
    {
        /// <inheritdoc />
        public override global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType existingValue,
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
                        return global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceMicrosoftTypeExtensions.ToValueString(value));
        }
    }
}
