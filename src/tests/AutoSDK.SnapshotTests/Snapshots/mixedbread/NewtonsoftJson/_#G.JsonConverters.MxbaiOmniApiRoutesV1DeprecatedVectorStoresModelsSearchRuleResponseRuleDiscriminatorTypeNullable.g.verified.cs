//HintName: G.JsonConverters.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType? existingValue,
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
                        return global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleResponseRuleDiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
