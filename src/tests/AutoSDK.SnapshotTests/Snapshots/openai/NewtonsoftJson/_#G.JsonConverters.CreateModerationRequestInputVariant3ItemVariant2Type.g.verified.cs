//HintName: G.JsonConverters.CreateModerationRequestInputVariant3ItemVariant2Type.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateModerationRequestInputVariant3ItemVariant2TypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateModerationRequestInputVariant3ItemVariant2Type>
    {
        /// <inheritdoc />
        public override global::G.CreateModerationRequestInputVariant3ItemVariant2Type ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateModerationRequestInputVariant3ItemVariant2Type existingValue,
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
                        return global::G.CreateModerationRequestInputVariant3ItemVariant2TypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateModerationRequestInputVariant3ItemVariant2Type)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateModerationRequestInputVariant3ItemVariant2Type);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateModerationRequestInputVariant3ItemVariant2Type value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateModerationRequestInputVariant3ItemVariant2TypeExtensions.ToValueString(value));
        }
    }
}
