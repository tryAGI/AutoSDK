//HintName: G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType existingValue,
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
                        return global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeletedDeletedRuleDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
