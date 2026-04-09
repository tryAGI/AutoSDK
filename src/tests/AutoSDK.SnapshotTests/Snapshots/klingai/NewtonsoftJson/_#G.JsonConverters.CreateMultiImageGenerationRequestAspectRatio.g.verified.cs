//HintName: G.JsonConverters.CreateMultiImageGenerationRequestAspectRatio.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateMultiImageGenerationRequestAspectRatioJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateMultiImageGenerationRequestAspectRatio>
    {
        /// <inheritdoc />
        public override global::G.CreateMultiImageGenerationRequestAspectRatio ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateMultiImageGenerationRequestAspectRatio existingValue,
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
                        return global::G.CreateMultiImageGenerationRequestAspectRatioExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateMultiImageGenerationRequestAspectRatio)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateMultiImageGenerationRequestAspectRatio);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateMultiImageGenerationRequestAspectRatio value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateMultiImageGenerationRequestAspectRatioExtensions.ToValueString(value));
        }
    }
}
