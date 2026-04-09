//HintName: G.JsonConverters.ProjectExtendedResponseModelApplyTextNormalizationNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProjectExtendedResponseModelApplyTextNormalizationNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ProjectExtendedResponseModelApplyTextNormalization?>
    {
        /// <inheritdoc />
        public override global::G.ProjectExtendedResponseModelApplyTextNormalization? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ProjectExtendedResponseModelApplyTextNormalization? existingValue,
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
                        return global::G.ProjectExtendedResponseModelApplyTextNormalizationExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ProjectExtendedResponseModelApplyTextNormalization)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ProjectExtendedResponseModelApplyTextNormalization?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ProjectExtendedResponseModelApplyTextNormalization? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.ProjectExtendedResponseModelApplyTextNormalizationExtensions.ToValueString(value.Value));
            }
        }
    }
}
