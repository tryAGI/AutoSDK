//HintName: G.JsonConverters.EditImageGetLayersVariant2ImageUseForAIBackground.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class EditImageGetLayersVariant2ImageUseForAIBackgroundJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.EditImageGetLayersVariant2ImageUseForAIBackground>
    {
        /// <inheritdoc />
        public override global::G.EditImageGetLayersVariant2ImageUseForAIBackground ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.EditImageGetLayersVariant2ImageUseForAIBackground existingValue,
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
                        return global::G.EditImageGetLayersVariant2ImageUseForAIBackgroundExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.EditImageGetLayersVariant2ImageUseForAIBackground)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.EditImageGetLayersVariant2ImageUseForAIBackground);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.EditImageGetLayersVariant2ImageUseForAIBackground value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.EditImageGetLayersVariant2ImageUseForAIBackgroundExtensions.ToValueString(value));
        }
    }
}
