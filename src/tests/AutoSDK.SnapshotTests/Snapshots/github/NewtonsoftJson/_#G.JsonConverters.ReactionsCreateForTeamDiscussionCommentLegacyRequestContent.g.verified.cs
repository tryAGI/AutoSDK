//HintName: G.JsonConverters.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReactionsCreateForTeamDiscussionCommentLegacyRequestContentJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent>
    {
        /// <inheritdoc />
        public override global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContentExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContent value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ReactionsCreateForTeamDiscussionCommentLegacyRequestContentExtensions.ToValueString(value));
        }
    }
}
