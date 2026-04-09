//HintName: G.JsonConverters.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateProjectAutomationConfigVariant2ExportDefinitionVariant3TypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type?>
    {
        /// <inheritdoc />
        public override global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type? existingValue,
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
                        return global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3TypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3Type? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.CreateProjectAutomationConfigVariant2ExportDefinitionVariant3TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
