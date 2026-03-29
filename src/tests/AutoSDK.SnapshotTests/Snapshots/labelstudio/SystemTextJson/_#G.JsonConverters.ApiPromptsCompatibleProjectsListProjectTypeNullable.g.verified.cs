//HintName: G.JsonConverters.ApiPromptsCompatibleProjectsListProjectTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApiPromptsCompatibleProjectsListProjectTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ApiPromptsCompatibleProjectsListProjectType?>
    {
        /// <inheritdoc />
        public override global::G.ApiPromptsCompatibleProjectsListProjectType? Read(
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
                        return global::G.ApiPromptsCompatibleProjectsListProjectTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ApiPromptsCompatibleProjectsListProjectType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ApiPromptsCompatibleProjectsListProjectType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ApiPromptsCompatibleProjectsListProjectType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ApiPromptsCompatibleProjectsListProjectTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
