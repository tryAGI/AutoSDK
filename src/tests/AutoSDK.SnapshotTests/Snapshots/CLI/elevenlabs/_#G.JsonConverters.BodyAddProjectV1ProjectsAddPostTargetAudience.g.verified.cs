//HintName: G.JsonConverters.BodyAddProjectV1ProjectsAddPostTargetAudience.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyAddProjectV1ProjectsAddPostTargetAudienceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.BodyAddProjectV1ProjectsAddPostTargetAudience>
    {
        /// <inheritdoc />
        public override global::G.BodyAddProjectV1ProjectsAddPostTargetAudience Read(
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
                        return global::G.BodyAddProjectV1ProjectsAddPostTargetAudienceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.BodyAddProjectV1ProjectsAddPostTargetAudience)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.BodyAddProjectV1ProjectsAddPostTargetAudience);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.BodyAddProjectV1ProjectsAddPostTargetAudience value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.BodyAddProjectV1ProjectsAddPostTargetAudienceExtensions.ToValueString(value));
        }
    }
}
