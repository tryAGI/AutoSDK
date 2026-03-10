//HintName: G.JsonConverters.GetToolDependentAgentsResponseModelAgentDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetToolDependentAgentsResponseModelAgentDiscriminatorTypeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.GetToolDependentAgentsResponseModelAgentDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.GetToolDependentAgentsResponseModelAgentDiscriminatorType Read(
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
                        return global::G.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.GetToolDependentAgentsResponseModelAgentDiscriminatorType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.GetToolDependentAgentsResponseModelAgentDiscriminatorType);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.GetToolDependentAgentsResponseModelAgentDiscriminatorType value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.GetToolDependentAgentsResponseModelAgentDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
