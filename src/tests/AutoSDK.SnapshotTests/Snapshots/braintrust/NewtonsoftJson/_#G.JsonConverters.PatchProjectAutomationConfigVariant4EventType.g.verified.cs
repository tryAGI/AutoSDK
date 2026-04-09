//HintName: G.JsonConverters.PatchProjectAutomationConfigVariant4EventType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchProjectAutomationConfigVariant4EventTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PatchProjectAutomationConfigVariant4EventType>
    {
        /// <inheritdoc />
        public override global::G.PatchProjectAutomationConfigVariant4EventType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PatchProjectAutomationConfigVariant4EventType existingValue,
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
                        return global::G.PatchProjectAutomationConfigVariant4EventTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PatchProjectAutomationConfigVariant4EventType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PatchProjectAutomationConfigVariant4EventType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PatchProjectAutomationConfigVariant4EventType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PatchProjectAutomationConfigVariant4EventTypeExtensions.ToValueString(value));
        }
    }
}
