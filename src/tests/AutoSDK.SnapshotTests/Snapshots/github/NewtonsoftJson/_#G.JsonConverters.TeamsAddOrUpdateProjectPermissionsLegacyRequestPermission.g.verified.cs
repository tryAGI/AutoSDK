//HintName: G.JsonConverters.TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TeamsAddOrUpdateProjectPermissionsLegacyRequestPermissionJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission>
    {
        /// <inheritdoc />
        public override global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission existingValue,
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
                        return global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequestPermissionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequestPermission value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.TeamsAddOrUpdateProjectPermissionsLegacyRequestPermissionExtensions.ToValueString(value));
        }
    }
}
