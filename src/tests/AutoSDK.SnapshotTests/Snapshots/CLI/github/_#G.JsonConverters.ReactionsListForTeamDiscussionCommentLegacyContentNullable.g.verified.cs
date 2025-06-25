//HintName: G.JsonConverters.ReactionsListForTeamDiscussionCommentLegacyContentNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReactionsListForTeamDiscussionCommentLegacyContentNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReactionsListForTeamDiscussionCommentLegacyContent?>
    {
        /// <inheritdoc />
        public override global::G.ReactionsListForTeamDiscussionCommentLegacyContent? Read(
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
                        return global::G.ReactionsListForTeamDiscussionCommentLegacyContentExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ReactionsListForTeamDiscussionCommentLegacyContent)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ReactionsListForTeamDiscussionCommentLegacyContent?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReactionsListForTeamDiscussionCommentLegacyContent? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ReactionsListForTeamDiscussionCommentLegacyContentExtensions.ToValueString(value.Value));
            }
        }
    }
}
