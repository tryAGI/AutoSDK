﻿//HintName: G.JsonConverters.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReactionsCreateForTeamDiscussionCommentInOrgRequestContentJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent>
    {
        /// <inheritdoc />
        public override global::G.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent Read(
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
                        return global::G.ReactionsCreateForTeamDiscussionCommentInOrgRequestContentExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ReactionsCreateForTeamDiscussionCommentInOrgRequestContent value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ReactionsCreateForTeamDiscussionCommentInOrgRequestContentExtensions.ToValueString(value));
        }
    }
}
