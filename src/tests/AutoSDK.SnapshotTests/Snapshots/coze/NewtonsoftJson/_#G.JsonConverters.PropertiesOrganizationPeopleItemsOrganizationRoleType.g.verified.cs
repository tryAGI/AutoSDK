//HintName: G.JsonConverters.PropertiesOrganizationPeopleItemsOrganizationRoleType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PropertiesOrganizationPeopleItemsOrganizationRoleTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PropertiesOrganizationPeopleItemsOrganizationRoleType>
    {
        /// <inheritdoc />
        public override global::G.PropertiesOrganizationPeopleItemsOrganizationRoleType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PropertiesOrganizationPeopleItemsOrganizationRoleType existingValue,
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
                        return global::G.PropertiesOrganizationPeopleItemsOrganizationRoleTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PropertiesOrganizationPeopleItemsOrganizationRoleType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PropertiesOrganizationPeopleItemsOrganizationRoleType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PropertiesOrganizationPeopleItemsOrganizationRoleType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PropertiesOrganizationPeopleItemsOrganizationRoleTypeExtensions.ToValueString(value));
        }
    }
}
