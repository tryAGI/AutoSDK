//HintName: G.JsonConverters.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProjectAutomationConfigVariant2ExportDefinitionVariant3TypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type>
    {
        /// <inheritdoc />
        public override global::G.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type existingValue,
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
                        return global::G.ProjectAutomationConfigVariant2ExportDefinitionVariant3TypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ProjectAutomationConfigVariant2ExportDefinitionVariant3Type value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ProjectAutomationConfigVariant2ExportDefinitionVariant3TypeExtensions.ToValueString(value));
        }
    }
}
