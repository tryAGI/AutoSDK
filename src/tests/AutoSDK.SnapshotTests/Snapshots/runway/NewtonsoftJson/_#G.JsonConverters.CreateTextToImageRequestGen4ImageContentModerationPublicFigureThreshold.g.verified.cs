//HintName: G.JsonConverters.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold>
    {
        /// <inheritdoc />
        public override global::G.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold existingValue,
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
                        return global::G.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThreshold value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdExtensions.ToValueString(value));
        }
    }
}
