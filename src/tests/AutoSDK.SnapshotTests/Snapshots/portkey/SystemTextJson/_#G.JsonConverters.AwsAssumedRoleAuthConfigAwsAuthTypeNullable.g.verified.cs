//HintName: G.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AwsAssumedRoleAuthConfigAwsAuthTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.AwsAssumedRoleAuthConfigAwsAuthType?>
    {
        /// <inheritdoc />
        public override global::G.AwsAssumedRoleAuthConfigAwsAuthType? Read(
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
                        return global::G.AwsAssumedRoleAuthConfigAwsAuthTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.AwsAssumedRoleAuthConfigAwsAuthType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.AwsAssumedRoleAuthConfigAwsAuthType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.AwsAssumedRoleAuthConfigAwsAuthType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.AwsAssumedRoleAuthConfigAwsAuthTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
