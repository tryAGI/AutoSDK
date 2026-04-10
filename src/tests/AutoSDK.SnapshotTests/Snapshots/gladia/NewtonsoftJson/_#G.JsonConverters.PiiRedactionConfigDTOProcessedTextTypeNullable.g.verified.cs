//HintName: G.JsonConverters.PiiRedactionConfigDTOProcessedTextTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PiiRedactionConfigDTOProcessedTextTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PiiRedactionConfigDTOProcessedTextType?>
    {
        /// <inheritdoc />
        public override global::G.PiiRedactionConfigDTOProcessedTextType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PiiRedactionConfigDTOProcessedTextType? existingValue,
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
                        return global::G.PiiRedactionConfigDTOProcessedTextTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PiiRedactionConfigDTOProcessedTextType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PiiRedactionConfigDTOProcessedTextType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PiiRedactionConfigDTOProcessedTextType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.PiiRedactionConfigDTOProcessedTextTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
