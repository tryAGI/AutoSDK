//HintName: G.JsonConverters.UpdateAssistantDTOFirstMessageMode.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class UpdateAssistantDTOFirstMessageModeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.UpdateAssistantDTOFirstMessageMode>
    {
        /// <inheritdoc />
        public override global::G.UpdateAssistantDTOFirstMessageMode ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.UpdateAssistantDTOFirstMessageMode existingValue,
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
                        return global::G.UpdateAssistantDTOFirstMessageModeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.UpdateAssistantDTOFirstMessageMode)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.UpdateAssistantDTOFirstMessageMode);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.UpdateAssistantDTOFirstMessageMode value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.UpdateAssistantDTOFirstMessageModeExtensions.ToValueString(value));
        }
    }
}
