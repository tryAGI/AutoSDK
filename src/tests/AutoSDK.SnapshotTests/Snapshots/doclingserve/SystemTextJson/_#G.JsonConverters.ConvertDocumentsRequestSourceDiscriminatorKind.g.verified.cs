//HintName: G.JsonConverters.ConvertDocumentsRequestSourceDiscriminatorKind.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ConvertDocumentsRequestSourceDiscriminatorKindJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ConvertDocumentsRequestSourceDiscriminatorKind>
    {
        /// <inheritdoc />
        public override global::G.ConvertDocumentsRequestSourceDiscriminatorKind Read(
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
                        return global::G.ConvertDocumentsRequestSourceDiscriminatorKindExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ConvertDocumentsRequestSourceDiscriminatorKind)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ConvertDocumentsRequestSourceDiscriminatorKind);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ConvertDocumentsRequestSourceDiscriminatorKind value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ConvertDocumentsRequestSourceDiscriminatorKindExtensions.ToValueString(value));
        }
    }
}
