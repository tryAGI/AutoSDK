//HintName: G.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateProjectAutomationConfigVariant2ExportDefinitionVariant2TypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type>
    {
        /// <inheritdoc />
        public override global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type existingValue,
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
                        return global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2TypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2Type value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant2TypeExtensions.ToValueString(value));
        }
    }
}
