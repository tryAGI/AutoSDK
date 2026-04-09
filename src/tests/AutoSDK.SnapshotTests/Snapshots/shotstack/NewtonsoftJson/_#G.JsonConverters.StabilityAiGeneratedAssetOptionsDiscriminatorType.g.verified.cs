//HintName: G.JsonConverters.StabilityAiGeneratedAssetOptionsDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class StabilityAiGeneratedAssetOptionsDiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.StabilityAiGeneratedAssetOptionsDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.StabilityAiGeneratedAssetOptionsDiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.StabilityAiGeneratedAssetOptionsDiscriminatorType existingValue,
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
                        return global::G.StabilityAiGeneratedAssetOptionsDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.StabilityAiGeneratedAssetOptionsDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.StabilityAiGeneratedAssetOptionsDiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.StabilityAiGeneratedAssetOptionsDiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.StabilityAiGeneratedAssetOptionsDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
