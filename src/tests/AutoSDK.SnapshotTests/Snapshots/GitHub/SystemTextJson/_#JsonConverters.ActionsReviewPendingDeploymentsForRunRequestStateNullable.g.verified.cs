//HintName: JsonConverters.ActionsReviewPendingDeploymentsForRunRequestStateNullable.g.cs
#nullable enable

namespace AutoSDK.JsonConverters
{
    /// <inheritdoc />
    public sealed class ActionsReviewPendingDeploymentsForRunRequestStateNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ActionsReviewPendingDeploymentsForRunRequestState?>
    {
        /// <inheritdoc />
        public override global::G.ActionsReviewPendingDeploymentsForRunRequestState? Read(
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
                        return global::G.ActionsReviewPendingDeploymentsForRunRequestStateExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ActionsReviewPendingDeploymentsForRunRequestState)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ActionsReviewPendingDeploymentsForRunRequestState? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.ActionsReviewPendingDeploymentsForRunRequestStateExtensions.ToValueString(value.Value));
            }
        }
    }
}
