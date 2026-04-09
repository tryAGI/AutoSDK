//HintName: G.JsonConverters.EditImageGetLayersVariant2ImageVerticalAlignment.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class EditImageGetLayersVariant2ImageVerticalAlignmentJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.EditImageGetLayersVariant2ImageVerticalAlignment>
    {
        /// <inheritdoc />
        public override global::G.EditImageGetLayersVariant2ImageVerticalAlignment ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.EditImageGetLayersVariant2ImageVerticalAlignment existingValue,
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
                        return global::G.EditImageGetLayersVariant2ImageVerticalAlignmentExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.EditImageGetLayersVariant2ImageVerticalAlignment)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.EditImageGetLayersVariant2ImageVerticalAlignment);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.EditImageGetLayersVariant2ImageVerticalAlignment value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.EditImageGetLayersVariant2ImageVerticalAlignmentExtensions.ToValueString(value));
        }
    }
}
