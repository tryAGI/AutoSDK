//HintName: G.JsonConverters.SkipResponseEdgeVariant2TransitionConditionType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SkipResponseEdgeVariant2TransitionConditionTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.SkipResponseEdgeVariant2TransitionConditionType>
    {
        /// <inheritdoc />
        public override global::G.SkipResponseEdgeVariant2TransitionConditionType Read(
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
                        return global::G.SkipResponseEdgeVariant2TransitionConditionTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.SkipResponseEdgeVariant2TransitionConditionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.SkipResponseEdgeVariant2TransitionConditionType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.SkipResponseEdgeVariant2TransitionConditionType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.SkipResponseEdgeVariant2TransitionConditionTypeExtensions.ToValueString(value));
        }
    }
}
