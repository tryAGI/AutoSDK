//HintName: G.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class DubbingTranscriptsResponseModelTranscriptFormatNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.DubbingTranscriptsResponseModelTranscriptFormat?>
    {
        /// <inheritdoc />
        public override global::G.DubbingTranscriptsResponseModelTranscriptFormat? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.DubbingTranscriptsResponseModelTranscriptFormat? existingValue,
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
                        return global::G.DubbingTranscriptsResponseModelTranscriptFormatExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.DubbingTranscriptsResponseModelTranscriptFormat)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.DubbingTranscriptsResponseModelTranscriptFormat?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.DubbingTranscriptsResponseModelTranscriptFormat? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.DubbingTranscriptsResponseModelTranscriptFormatExtensions.ToValueString(value.Value));
            }
        }
    }
}
