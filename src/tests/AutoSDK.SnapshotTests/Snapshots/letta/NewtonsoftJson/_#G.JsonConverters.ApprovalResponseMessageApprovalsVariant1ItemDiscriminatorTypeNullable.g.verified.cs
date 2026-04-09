//HintName: G.JsonConverters.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType?>
    {
        /// <inheritdoc />
        public override global::G.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType? existingValue,
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
                        return global::G.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.ApprovalResponseMessageApprovalsVariant1ItemDiscriminatorTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
