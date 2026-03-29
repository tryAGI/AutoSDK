//HintName: G.JsonConverters.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRoleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole>
    {
        /// <inheritdoc />
        public override global::G.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole Read(
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
                        return global::G.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRoleExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRole value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.TemplatesCreateAgentsFromTemplateRequestInitialMessageSequenceItemRoleExtensions.ToValueString(value));
        }
    }
}
