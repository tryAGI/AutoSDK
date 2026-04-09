//HintName: G.JsonConverters.MetadataSendTelemetryRequestEventVariant1Type.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MetadataSendTelemetryRequestEventVariant1TypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.MetadataSendTelemetryRequestEventVariant1Type>
    {
        /// <inheritdoc />
        public override global::G.MetadataSendTelemetryRequestEventVariant1Type ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.MetadataSendTelemetryRequestEventVariant1Type existingValue,
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
                        return global::G.MetadataSendTelemetryRequestEventVariant1TypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.MetadataSendTelemetryRequestEventVariant1Type)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.MetadataSendTelemetryRequestEventVariant1Type);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.MetadataSendTelemetryRequestEventVariant1Type value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.MetadataSendTelemetryRequestEventVariant1TypeExtensions.ToValueString(value));
        }
    }
}
