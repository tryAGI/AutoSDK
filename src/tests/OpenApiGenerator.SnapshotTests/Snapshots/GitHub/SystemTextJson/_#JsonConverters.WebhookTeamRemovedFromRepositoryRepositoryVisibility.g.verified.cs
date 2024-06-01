//HintName: JsonConverters.WebhookTeamRemovedFromRepositoryRepositoryVisibility.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class WebhookTeamRemovedFromRepositoryRepositoryVisibilityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.WebhookTeamRemovedFromRepositoryRepositoryVisibility>
    {
        /// <inheritdoc />
        public override global::G.WebhookTeamRemovedFromRepositoryRepositoryVisibility Read(
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
                        return global::G.WebhookTeamRemovedFromRepositoryRepositoryVisibilityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.WebhookTeamRemovedFromRepositoryRepositoryVisibility)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.WebhookTeamRemovedFromRepositoryRepositoryVisibility value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.WebhookTeamRemovedFromRepositoryRepositoryVisibilityExtensions.ToValueString(value));
        }
    }
}
