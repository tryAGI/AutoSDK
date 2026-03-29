//HintName: G.JsonConverters.PostToolRouterSessionRequestToolsVariant3TagsDisableItemNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostToolRouterSessionRequestToolsVariant3TagsDisableItemNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PostToolRouterSessionRequestToolsVariant3TagsDisableItem?>
    {
        /// <inheritdoc />
        public override global::G.PostToolRouterSessionRequestToolsVariant3TagsDisableItem? Read(
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
                        return global::G.PostToolRouterSessionRequestToolsVariant3TagsDisableItemExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PostToolRouterSessionRequestToolsVariant3TagsDisableItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PostToolRouterSessionRequestToolsVariant3TagsDisableItem?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PostToolRouterSessionRequestToolsVariant3TagsDisableItem? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.PostToolRouterSessionRequestToolsVariant3TagsDisableItemExtensions.ToValueString(value.Value));
            }
        }
    }
}
