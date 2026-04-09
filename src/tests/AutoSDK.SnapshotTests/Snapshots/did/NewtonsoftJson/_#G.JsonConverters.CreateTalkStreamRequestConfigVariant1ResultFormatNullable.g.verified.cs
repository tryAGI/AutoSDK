//HintName: G.JsonConverters.CreateTalkStreamRequestConfigVariant1ResultFormatNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTalkStreamRequestConfigVariant1ResultFormatNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateTalkStreamRequestConfigVariant1ResultFormat?>
    {
        /// <inheritdoc />
        public override global::G.CreateTalkStreamRequestConfigVariant1ResultFormat? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateTalkStreamRequestConfigVariant1ResultFormat? existingValue,
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
                        return global::G.CreateTalkStreamRequestConfigVariant1ResultFormatExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateTalkStreamRequestConfigVariant1ResultFormat)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateTalkStreamRequestConfigVariant1ResultFormat?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateTalkStreamRequestConfigVariant1ResultFormat? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.CreateTalkStreamRequestConfigVariant1ResultFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
