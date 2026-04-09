//HintName: G.JsonConverters.EditImageGetVirtualModelSceneVariant1PresetNameNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class EditImageGetVirtualModelSceneVariant1PresetNameNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.EditImageGetVirtualModelSceneVariant1PresetName?>
    {
        /// <inheritdoc />
        public override global::G.EditImageGetVirtualModelSceneVariant1PresetName? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.EditImageGetVirtualModelSceneVariant1PresetName? existingValue,
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
                        return global::G.EditImageGetVirtualModelSceneVariant1PresetNameExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.EditImageGetVirtualModelSceneVariant1PresetName)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.EditImageGetVirtualModelSceneVariant1PresetName?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.EditImageGetVirtualModelSceneVariant1PresetName? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.EditImageGetVirtualModelSceneVariant1PresetNameExtensions.ToValueString(value.Value));
            }
        }
    }
}
