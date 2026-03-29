//HintName: G.JsonConverters.OutputItemWebSearchCallActionOneOf0SourcesItemsType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class OutputItemWebSearchCallActionOneOf0SourcesItemsTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsType>
    {
        /// <inheritdoc />
        public override global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsType Read(
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
                        return global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.OutputItemWebSearchCallActionOneOf0SourcesItemsTypeExtensions.ToValueString(value));
        }
    }
}
