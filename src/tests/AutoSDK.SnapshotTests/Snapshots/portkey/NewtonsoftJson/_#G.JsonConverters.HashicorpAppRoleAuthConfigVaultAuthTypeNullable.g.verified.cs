//HintName: G.JsonConverters.HashicorpAppRoleAuthConfigVaultAuthTypeNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class HashicorpAppRoleAuthConfigVaultAuthTypeNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.HashicorpAppRoleAuthConfigVaultAuthType?>
    {
        /// <inheritdoc />
        public override global::G.HashicorpAppRoleAuthConfigVaultAuthType? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.HashicorpAppRoleAuthConfigVaultAuthType? existingValue,
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
                        return global::G.HashicorpAppRoleAuthConfigVaultAuthTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.HashicorpAppRoleAuthConfigVaultAuthType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.HashicorpAppRoleAuthConfigVaultAuthType?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.HashicorpAppRoleAuthConfigVaultAuthType? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.HashicorpAppRoleAuthConfigVaultAuthTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
