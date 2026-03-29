//HintName: G.JsonConverters.HMACAuthenticationPlanAlgorithm.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class HMACAuthenticationPlanAlgorithmJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.HMACAuthenticationPlanAlgorithm>
    {
        /// <inheritdoc />
        public override global::G.HMACAuthenticationPlanAlgorithm Read(
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
                        return global::G.HMACAuthenticationPlanAlgorithmExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.HMACAuthenticationPlanAlgorithm)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.HMACAuthenticationPlanAlgorithm);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.HMACAuthenticationPlanAlgorithm value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.HMACAuthenticationPlanAlgorithmExtensions.ToValueString(value));
        }
    }
}
