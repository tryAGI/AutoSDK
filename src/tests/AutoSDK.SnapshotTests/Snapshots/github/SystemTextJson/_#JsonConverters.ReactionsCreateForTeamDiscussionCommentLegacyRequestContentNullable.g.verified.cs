//HintName: JsonConverters.ReactionsCreateForTeamDiscussionCommentLegacyRequestContentNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReactionsCreateForTeamDiscussionCommentLegacyRequestContentNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent?>
    {
        /// <inheritdoc />
        public override global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent? Read(
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
                        return global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContentExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContentExtensions.ToValueString(value.Value));
            }
        }
    }
}
