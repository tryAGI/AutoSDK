//HintName: G.JsonConverters.PullsCreateReviewCommentRequestStartSide.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PullsCreateReviewCommentRequestStartSideJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PullsCreateReviewCommentRequestStartSide>
    {
        /// <inheritdoc />
        public override global::G.PullsCreateReviewCommentRequestStartSide ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PullsCreateReviewCommentRequestStartSide existingValue,
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
                        return global::G.PullsCreateReviewCommentRequestStartSideExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PullsCreateReviewCommentRequestStartSide)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PullsCreateReviewCommentRequestStartSide);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PullsCreateReviewCommentRequestStartSide value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PullsCreateReviewCommentRequestStartSideExtensions.ToValueString(value));
        }
    }
}
