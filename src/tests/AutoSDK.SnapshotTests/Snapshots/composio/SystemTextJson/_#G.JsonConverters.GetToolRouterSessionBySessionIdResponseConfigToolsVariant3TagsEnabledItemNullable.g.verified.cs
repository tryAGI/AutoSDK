//HintName: G.JsonConverters.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItemNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem?>
    {
        /// <inheritdoc />
        public override global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem? Read(
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
                        return global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItem? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.GetToolRouterSessionBySessionIdResponseConfigToolsVariant3TagsEnabledItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
