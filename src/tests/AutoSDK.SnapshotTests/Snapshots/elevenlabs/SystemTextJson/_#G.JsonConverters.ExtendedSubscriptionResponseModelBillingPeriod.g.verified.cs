﻿//HintName: G.JsonConverters.ExtendedSubscriptionResponseModelBillingPeriod.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ExtendedSubscriptionResponseModelBillingPeriodJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ExtendedSubscriptionResponseModelBillingPeriod>
    {
        /// <inheritdoc />
        public override global::G.ExtendedSubscriptionResponseModelBillingPeriod Read(
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
                        return global::G.ExtendedSubscriptionResponseModelBillingPeriodExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ExtendedSubscriptionResponseModelBillingPeriod)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.ExtendedSubscriptionResponseModelBillingPeriod);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ExtendedSubscriptionResponseModelBillingPeriod value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.ExtendedSubscriptionResponseModelBillingPeriodExtensions.ToValueString(value));
        }
    }
}
