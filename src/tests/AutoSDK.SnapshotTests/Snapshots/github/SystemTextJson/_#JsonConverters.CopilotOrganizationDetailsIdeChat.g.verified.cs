//HintName: JsonConverters.CopilotOrganizationDetailsIdeChat.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CopilotOrganizationDetailsIdeChatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.CopilotOrganizationDetailsIdeChat>
    {
        /// <inheritdoc />
        public override global::G.CopilotOrganizationDetailsIdeChat Read(
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
                        return global::G.CopilotOrganizationDetailsIdeChatExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.CopilotOrganizationDetailsIdeChat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.CopilotOrganizationDetailsIdeChat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.CopilotOrganizationDetailsIdeChat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.CopilotOrganizationDetailsIdeChatExtensions.ToValueString(value));
        }
    }
}
