//HintName: JsonConverters.IssuesCreateMilestoneRequestState.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class IssuesCreateMilestoneRequestStateJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.IssuesCreateMilestoneRequestState>
    {
        /// <inheritdoc />
        public override global::G.IssuesCreateMilestoneRequestState Read(
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
                        return global::G.IssuesCreateMilestoneRequestStateExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.IssuesCreateMilestoneRequestState)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.IssuesCreateMilestoneRequestState value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.IssuesCreateMilestoneRequestStateExtensions.ToValueString(value));
        }
    }
}
