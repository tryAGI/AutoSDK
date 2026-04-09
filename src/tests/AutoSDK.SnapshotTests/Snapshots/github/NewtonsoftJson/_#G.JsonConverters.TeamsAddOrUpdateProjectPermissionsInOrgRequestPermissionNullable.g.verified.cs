//HintName: G.JsonConverters.TeamsAddOrUpdateProjectPermissionsInOrgRequestPermissionNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class TeamsAddOrUpdateProjectPermissionsInOrgRequestPermissionNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission?>
    {
        /// <inheritdoc />
        public override global::G.TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission? existingValue,
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
                        return global::G.TeamsAddOrUpdateProjectPermissionsInOrgRequestPermissionExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.TeamsAddOrUpdateProjectPermissionsInOrgRequestPermission? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.TeamsAddOrUpdateProjectPermissionsInOrgRequestPermissionExtensions.ToValueString(value.Value));
            }
        }
    }
}
