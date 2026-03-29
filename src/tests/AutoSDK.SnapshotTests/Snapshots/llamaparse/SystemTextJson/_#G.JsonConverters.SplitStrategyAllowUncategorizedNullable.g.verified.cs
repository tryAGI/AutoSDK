//HintName: G.JsonConverters.SplitStrategyAllowUncategorizedNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SplitStrategyAllowUncategorizedNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SplitStrategyAllowUncategorized?>
    {
        /// <inheritdoc />
        public override global::G.SplitStrategyAllowUncategorized? Read(
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
                        return global::G.SplitStrategyAllowUncategorizedExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.SplitStrategyAllowUncategorized)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.SplitStrategyAllowUncategorized?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SplitStrategyAllowUncategorized? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.SplitStrategyAllowUncategorizedExtensions.ToValueString(value.Value));
            }
        }
    }
}
