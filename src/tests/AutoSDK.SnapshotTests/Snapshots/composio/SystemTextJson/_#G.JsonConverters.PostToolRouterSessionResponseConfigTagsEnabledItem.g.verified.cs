//HintName: G.JsonConverters.PostToolRouterSessionResponseConfigTagsEnabledItem.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PostToolRouterSessionResponseConfigTagsEnabledItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PostToolRouterSessionResponseConfigTagsEnabledItem>
    {
        /// <inheritdoc />
        public override global::G.PostToolRouterSessionResponseConfigTagsEnabledItem Read(
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
                        return global::G.PostToolRouterSessionResponseConfigTagsEnabledItemExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PostToolRouterSessionResponseConfigTagsEnabledItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PostToolRouterSessionResponseConfigTagsEnabledItem);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PostToolRouterSessionResponseConfigTagsEnabledItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PostToolRouterSessionResponseConfigTagsEnabledItemExtensions.ToValueString(value));
        }
    }
}
