//HintName: JsonConverters.ActionsOrganizationPermissionsAllowedActions.g.cs
#nullable enable

namespace OpenApiGenerator.JsonConverters
{
    /// <inheritdoc />
    public sealed class ActionsOrganizationPermissionsAllowedActionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ActionsOrganizationPermissionsAllowedActions>
    {
        /// <inheritdoc />
        public override global::G.ActionsOrganizationPermissionsAllowedActions Read(
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
                        return global::G.ActionsOrganizationPermissionsAllowedActionsExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.ActionsOrganizationPermissionsAllowedActions)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException();
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ActionsOrganizationPermissionsAllowedActions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer.WriteStringValue(global::G.ActionsOrganizationPermissionsAllowedActionsExtensions.ToValueString(value));
        }
    }
}
