//HintName: G.JsonConverters.VideoToTextControllerVideoTranscriptionRequestOutputFormatNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class VideoToTextControllerVideoTranscriptionRequestOutputFormatNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.VideoToTextControllerVideoTranscriptionRequestOutputFormat?>
    {
        /// <inheritdoc />
        public override global::G.VideoToTextControllerVideoTranscriptionRequestOutputFormat? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.VideoToTextControllerVideoTranscriptionRequestOutputFormat? existingValue,
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
                        return global::G.VideoToTextControllerVideoTranscriptionRequestOutputFormatExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.VideoToTextControllerVideoTranscriptionRequestOutputFormat)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.VideoToTextControllerVideoTranscriptionRequestOutputFormat?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.VideoToTextControllerVideoTranscriptionRequestOutputFormat? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.VideoToTextControllerVideoTranscriptionRequestOutputFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
