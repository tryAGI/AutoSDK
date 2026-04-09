//HintName: G.JsonConverters.AWSIAMCredentialsAuthenticationPlanTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AWSIAMCredentialsAuthenticationPlanTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.AWSIAMCredentialsAuthenticationPlanType?>
    {
        /// <inheritdoc />
        public override global::G.AWSIAMCredentialsAuthenticationPlanType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.AWSIAMCredentialsAuthenticationPlanType? existingValue,
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
                        return global::G.AWSIAMCredentialsAuthenticationPlanTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.AWSIAMCredentialsAuthenticationPlanType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.AWSIAMCredentialsAuthenticationPlanType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.AWSIAMCredentialsAuthenticationPlanType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.AWSIAMCredentialsAuthenticationPlanTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
