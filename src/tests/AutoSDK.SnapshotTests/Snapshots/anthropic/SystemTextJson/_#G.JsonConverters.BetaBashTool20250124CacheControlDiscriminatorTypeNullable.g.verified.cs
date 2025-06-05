//HintName: G.JsonConverters.BetaBashTool20250124CacheControlDiscriminatorTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BetaBashTool20250124CacheControlDiscriminatorTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BetaBashTool20250124CacheControlDiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::G.BetaBashTool20250124CacheControlDiscriminatorType? Read(
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
                        return global::G.BetaBashTool20250124CacheControlDiscriminatorTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BetaBashTool20250124CacheControlDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.BetaBashTool20250124CacheControlDiscriminatorType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BetaBashTool20250124CacheControlDiscriminatorType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.BetaBashTool20250124CacheControlDiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
