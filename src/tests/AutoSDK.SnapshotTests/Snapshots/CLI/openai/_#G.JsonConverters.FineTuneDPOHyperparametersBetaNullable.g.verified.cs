﻿//HintName: G.JsonConverters.FineTuneDPOHyperparametersBetaNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class FineTuneDPOHyperparametersBetaNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.FineTuneDPOHyperparametersBeta?>
    {
        /// <inheritdoc />
        public override global::G.FineTuneDPOHyperparametersBeta? Read(
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
                        return global::G.FineTuneDPOHyperparametersBetaExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.FineTuneDPOHyperparametersBeta)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.FineTuneDPOHyperparametersBeta?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.FineTuneDPOHyperparametersBeta? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.FineTuneDPOHyperparametersBetaExtensions.ToValueString(value.Value));
            }
        }
    }
}
