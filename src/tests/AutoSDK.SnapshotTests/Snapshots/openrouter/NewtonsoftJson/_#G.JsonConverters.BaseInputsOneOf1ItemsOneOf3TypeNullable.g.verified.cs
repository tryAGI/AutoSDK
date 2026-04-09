//HintName: G.JsonConverters.BaseInputsOneOf1ItemsOneOf3TypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class BaseInputsOneOf1ItemsOneOf3TypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.BaseInputsOneOf1ItemsOneOf3Type?>
    {
        /// <inheritdoc />
        public override global::G.BaseInputsOneOf1ItemsOneOf3Type? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.BaseInputsOneOf1ItemsOneOf3Type? existingValue,
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
                        return global::G.BaseInputsOneOf1ItemsOneOf3TypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.BaseInputsOneOf1ItemsOneOf3Type)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.BaseInputsOneOf1ItemsOneOf3Type?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.BaseInputsOneOf1ItemsOneOf3Type? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.BaseInputsOneOf1ItemsOneOf3TypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
