//HintName: G.JsonConverters.ViewOptionsTableViewOptionsQueryShapeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ViewOptionsTableViewOptionsQueryShapeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ViewOptionsTableViewOptionsQueryShape?>
    {
        /// <inheritdoc />
        public override global::G.ViewOptionsTableViewOptionsQueryShape? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ViewOptionsTableViewOptionsQueryShape? existingValue,
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
                        return global::G.ViewOptionsTableViewOptionsQueryShapeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ViewOptionsTableViewOptionsQueryShape)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ViewOptionsTableViewOptionsQueryShape?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ViewOptionsTableViewOptionsQueryShape? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.ViewOptionsTableViewOptionsQueryShapeExtensions.ToValueString(value.Value));
            }
        }
    }
}
