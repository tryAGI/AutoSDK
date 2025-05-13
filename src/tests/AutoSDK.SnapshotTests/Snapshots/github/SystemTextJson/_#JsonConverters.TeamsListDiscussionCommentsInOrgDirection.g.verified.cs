//HintName: JsonConverters.TeamsListDiscussionCommentsInOrgDirection.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TeamsListDiscussionCommentsInOrgDirectionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TeamsListDiscussionCommentsInOrgDirection>
    {
        /// <inheritdoc />
        public override global::G.TeamsListDiscussionCommentsInOrgDirection Read(
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
                        return global::G.TeamsListDiscussionCommentsInOrgDirectionExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.TeamsListDiscussionCommentsInOrgDirection)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.TeamsListDiscussionCommentsInOrgDirection);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TeamsListDiscussionCommentsInOrgDirection value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.TeamsListDiscussionCommentsInOrgDirectionExtensions.ToValueString(value));
        }
    }
}
