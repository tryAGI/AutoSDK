//HintName: JsonConverters.TeamsAddOrUpdateMembershipForUserInOrgRequestRoleNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TeamsAddOrUpdateMembershipForUserInOrgRequestRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.TeamsAddOrUpdateMembershipForUserInOrgRequestRole?>
    {
        /// <inheritdoc />
        public override global::G.TeamsAddOrUpdateMembershipForUserInOrgRequestRole? Read(
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
                        return global::G.TeamsAddOrUpdateMembershipForUserInOrgRequestRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.TeamsAddOrUpdateMembershipForUserInOrgRequestRole)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.TeamsAddOrUpdateMembershipForUserInOrgRequestRole?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.TeamsAddOrUpdateMembershipForUserInOrgRequestRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::G.TeamsAddOrUpdateMembershipForUserInOrgRequestRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
