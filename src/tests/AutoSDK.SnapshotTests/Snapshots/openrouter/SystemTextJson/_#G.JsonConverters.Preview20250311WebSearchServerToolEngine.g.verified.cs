//HintName: G.JsonConverters.Preview20250311WebSearchServerToolEngine.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class Preview20250311WebSearchServerToolEngineJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Preview20250311WebSearchServerToolEngine>
    {
        /// <inheritdoc />
        public override global::G.Preview20250311WebSearchServerToolEngine Read(
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
                        return global::G.Preview20250311WebSearchServerToolEngineExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.Preview20250311WebSearchServerToolEngine)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.Preview20250311WebSearchServerToolEngine);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Preview20250311WebSearchServerToolEngine value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.Preview20250311WebSearchServerToolEngineExtensions.ToValueString(value));
        }
    }
}
