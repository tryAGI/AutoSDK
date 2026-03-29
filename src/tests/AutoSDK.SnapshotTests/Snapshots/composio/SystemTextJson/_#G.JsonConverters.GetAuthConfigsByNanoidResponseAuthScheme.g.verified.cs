//HintName: G.JsonConverters.GetAuthConfigsByNanoidResponseAuthScheme.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetAuthConfigsByNanoidResponseAuthSchemeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetAuthConfigsByNanoidResponseAuthScheme>
    {
        /// <inheritdoc />
        public override global::G.GetAuthConfigsByNanoidResponseAuthScheme Read(
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
                        return global::G.GetAuthConfigsByNanoidResponseAuthSchemeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetAuthConfigsByNanoidResponseAuthScheme)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetAuthConfigsByNanoidResponseAuthScheme);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetAuthConfigsByNanoidResponseAuthScheme value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.GetAuthConfigsByNanoidResponseAuthSchemeExtensions.ToValueString(value));
        }
    }
}
