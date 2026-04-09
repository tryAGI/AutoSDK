//HintName: G.JsonConverters.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition?>
    {
        /// <inheritdoc />
        public override global::G.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition? existingValue,
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
                        return global::G.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePosition? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionExtensions.ToValueString(value.Value));
            }
        }
    }
}
