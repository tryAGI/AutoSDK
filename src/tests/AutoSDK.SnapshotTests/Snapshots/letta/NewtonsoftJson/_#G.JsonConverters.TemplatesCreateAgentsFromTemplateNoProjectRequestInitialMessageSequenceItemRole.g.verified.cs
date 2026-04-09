//HintName: G.JsonConverters.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRoleJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole>
    {
        /// <inheritdoc />
        public override global::G.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole existingValue,
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
                        return global::G.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRoleExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRole value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.TemplatesCreateAgentsFromTemplateNoProjectRequestInitialMessageSequenceItemRoleExtensions.ToValueString(value));
        }
    }
}
