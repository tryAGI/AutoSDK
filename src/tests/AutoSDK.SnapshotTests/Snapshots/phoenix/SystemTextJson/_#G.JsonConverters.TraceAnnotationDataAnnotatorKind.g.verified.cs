//HintName: G.JsonConverters.TraceAnnotationDataAnnotatorKind.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TraceAnnotationDataAnnotatorKindJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TraceAnnotationDataAnnotatorKind>
    {
        /// <inheritdoc />
        public override global::G.TraceAnnotationDataAnnotatorKind Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.TraceAnnotationDataAnnotatorKindExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.TraceAnnotationDataAnnotatorKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.TraceAnnotationDataAnnotatorKind);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TraceAnnotationDataAnnotatorKind value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.TraceAnnotationDataAnnotatorKindExtensions.ToValueString(value));
        }
    }
}
