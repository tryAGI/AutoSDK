//HintName: G.JsonConverters.EstimatePricingRequestVariant1EstimateType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class EstimatePricingRequestVariant1EstimateTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.EstimatePricingRequestVariant1EstimateType>
    {
        /// <inheritdoc />
        public override global::G.EstimatePricingRequestVariant1EstimateType Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.EstimatePricingRequestVariant1EstimateTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.EstimatePricingRequestVariant1EstimateType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.EstimatePricingRequestVariant1EstimateType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.EstimatePricingRequestVariant1EstimateType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.EstimatePricingRequestVariant1EstimateTypeExtensions.ToValueString(value));
        }
    }
}
