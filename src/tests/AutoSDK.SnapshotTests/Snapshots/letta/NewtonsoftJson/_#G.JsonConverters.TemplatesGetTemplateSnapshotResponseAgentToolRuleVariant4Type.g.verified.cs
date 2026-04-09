//HintName: G.JsonConverters.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4Type.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4TypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4Type>
    {
        /// <inheritdoc />
        public override global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4Type ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4Type existingValue,
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
                        return global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4TypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4Type)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4Type);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4Type value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.TemplatesGetTemplateSnapshotResponseAgentToolRuleVariant4TypeExtensions.ToValueString(value));
        }
    }
}
