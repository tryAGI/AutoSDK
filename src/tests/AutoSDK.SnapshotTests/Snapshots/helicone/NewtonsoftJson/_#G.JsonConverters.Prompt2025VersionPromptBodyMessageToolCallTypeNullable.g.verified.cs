//HintName: G.JsonConverters.Prompt2025VersionPromptBodyMessageToolCallTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class Prompt2025VersionPromptBodyMessageToolCallTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.Prompt2025VersionPromptBodyMessageToolCallType?>
    {
        /// <inheritdoc />
        public override global::G.Prompt2025VersionPromptBodyMessageToolCallType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.Prompt2025VersionPromptBodyMessageToolCallType? existingValue,
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
                        return global::G.Prompt2025VersionPromptBodyMessageToolCallTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.Prompt2025VersionPromptBodyMessageToolCallType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.Prompt2025VersionPromptBodyMessageToolCallType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.Prompt2025VersionPromptBodyMessageToolCallType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.Prompt2025VersionPromptBodyMessageToolCallTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
