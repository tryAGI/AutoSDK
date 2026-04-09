//HintName: G.JsonConverters.AwsAssumedRoleAuthConfigAwsAuthType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class AwsAssumedRoleAuthConfigAwsAuthTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.AwsAssumedRoleAuthConfigAwsAuthType>
    {
        /// <inheritdoc />
        public override global::G.AwsAssumedRoleAuthConfigAwsAuthType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.AwsAssumedRoleAuthConfigAwsAuthType existingValue,
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
                        return global::G.AwsAssumedRoleAuthConfigAwsAuthTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.AwsAssumedRoleAuthConfigAwsAuthType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.AwsAssumedRoleAuthConfigAwsAuthType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.AwsAssumedRoleAuthConfigAwsAuthType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.AwsAssumedRoleAuthConfigAwsAuthTypeExtensions.ToValueString(value));
        }
    }
}
