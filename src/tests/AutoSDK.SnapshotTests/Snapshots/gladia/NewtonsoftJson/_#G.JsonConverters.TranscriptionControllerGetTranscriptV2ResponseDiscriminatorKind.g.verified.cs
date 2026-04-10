//HintName: G.JsonConverters.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKindJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind>
    {
        /// <inheritdoc />
        public override global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind existingValue,
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
                        return global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKindExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKind value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKindExtensions.ToValueString(value));
        }
    }
}
