//HintName: G.JsonConverters.PullsCreateReviewCommentRequestSubjectType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PullsCreateReviewCommentRequestSubjectTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.PullsCreateReviewCommentRequestSubjectType>
    {
        /// <inheritdoc />
        public override global::G.PullsCreateReviewCommentRequestSubjectType Read(
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
                        return global::G.PullsCreateReviewCommentRequestSubjectTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.PullsCreateReviewCommentRequestSubjectType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.PullsCreateReviewCommentRequestSubjectType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.PullsCreateReviewCommentRequestSubjectType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.PullsCreateReviewCommentRequestSubjectTypeExtensions.ToValueString(value));
        }
    }
}
