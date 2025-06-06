﻿//HintName: G.JsonConverters.RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class RunStepDeltaStepDetailsToolCallsCodeObjectTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.RunStepDeltaStepDetailsToolCallsCodeObjectType?>
    {
        /// <inheritdoc />
        public override global::G.RunStepDeltaStepDetailsToolCallsCodeObjectType? Read(
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
                        return global::G.RunStepDeltaStepDetailsToolCallsCodeObjectTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.RunStepDeltaStepDetailsToolCallsCodeObjectType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.RunStepDeltaStepDetailsToolCallsCodeObjectType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.RunStepDeltaStepDetailsToolCallsCodeObjectType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.RunStepDeltaStepDetailsToolCallsCodeObjectTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
