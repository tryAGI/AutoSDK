//HintName: G.JsonConverters.TraceAnnotationDataAnnotatorKind.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TraceAnnotationDataAnnotatorKindJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.TraceAnnotationDataAnnotatorKind>
    {
        /// <inheritdoc />
        public override global::G.TraceAnnotationDataAnnotatorKind ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.TraceAnnotationDataAnnotatorKind existingValue,
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
                        return global::G.TraceAnnotationDataAnnotatorKindExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.TraceAnnotationDataAnnotatorKind)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.TraceAnnotationDataAnnotatorKind);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.TraceAnnotationDataAnnotatorKind value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.TraceAnnotationDataAnnotatorKindExtensions.ToValueString(value));
        }
    }
}
