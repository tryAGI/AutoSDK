//HintName: JsonConverters.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReactionsCreateForTeamDiscussionCommentLegacyRequestContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent>
    {
        /// <inheritdoc />
        public override global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent Read(
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
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContentExtensions.ToValueString(value));
        }
    }
}
