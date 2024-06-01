//HintName: JsonConverters.WebhookTeamDeletedRepositoryVisibility.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookTeamDeletedRepositoryVisibilityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookTeamDeletedRepositoryVisibility>
    {
        /// <inheritdoc />
        public override global::G.WebhookTeamDeletedRepositoryVisibility Read(
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
                        return global::G.WebhookTeamDeletedRepositoryVisibilityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookTeamDeletedRepositoryVisibility)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookTeamDeletedRepositoryVisibility value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookTeamDeletedRepositoryVisibilityExtensions.ToValueString(value));
        }
    }
}
