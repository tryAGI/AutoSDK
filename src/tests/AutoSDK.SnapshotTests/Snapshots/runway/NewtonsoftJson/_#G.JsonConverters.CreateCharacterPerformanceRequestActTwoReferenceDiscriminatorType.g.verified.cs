//HintName: G.JsonConverters.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType existingValue,
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
                        return global::G.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
