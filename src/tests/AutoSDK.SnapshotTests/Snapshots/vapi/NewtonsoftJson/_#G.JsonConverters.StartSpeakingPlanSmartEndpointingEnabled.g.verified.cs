//HintName: G.JsonConverters.StartSpeakingPlanSmartEndpointingEnabled.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class StartSpeakingPlanSmartEndpointingEnabledJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.StartSpeakingPlanSmartEndpointingEnabled>
    {
        /// <inheritdoc />
        public override global::G.StartSpeakingPlanSmartEndpointingEnabled ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.StartSpeakingPlanSmartEndpointingEnabled existingValue,
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
                        return global::G.StartSpeakingPlanSmartEndpointingEnabledExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.StartSpeakingPlanSmartEndpointingEnabled)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.StartSpeakingPlanSmartEndpointingEnabled);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.StartSpeakingPlanSmartEndpointingEnabled value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.StartSpeakingPlanSmartEndpointingEnabledExtensions.ToValueString(value));
        }
    }
}
