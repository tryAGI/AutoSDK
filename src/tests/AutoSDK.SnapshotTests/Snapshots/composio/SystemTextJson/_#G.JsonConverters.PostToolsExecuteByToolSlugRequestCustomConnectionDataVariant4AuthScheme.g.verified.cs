//HintName: G.JsonConverters.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthSchemeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme>
    {
        /// <inheritdoc />
        public override global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme Read(
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
                        return global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthSchemeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthScheme value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PostToolsExecuteByToolSlugRequestCustomConnectionDataVariant4AuthSchemeExtensions.ToValueString(value));
        }
    }
}
