//HintName: G.JsonConverters.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason>
    {
        /// <inheritdoc />
        public override global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason Read(
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
                        return global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReason value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.TransferToAgentToolResultSuccessModelBranchInfoVariant1DiscriminatorBranchReasonExtensions.ToValueString(value));
        }
    }
}
