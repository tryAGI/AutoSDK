//HintName: G.JsonConverters.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType existingValue,
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
                        return global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
