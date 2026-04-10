//HintName: G.JsonConverters.GroupSchemaManagerConfigDiscriminatorManagerType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GroupSchemaManagerConfigDiscriminatorManagerTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GroupSchemaManagerConfigDiscriminatorManagerType>
    {
        /// <inheritdoc />
        public override global::G.GroupSchemaManagerConfigDiscriminatorManagerType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GroupSchemaManagerConfigDiscriminatorManagerType existingValue,
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
                        return global::G.GroupSchemaManagerConfigDiscriminatorManagerTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GroupSchemaManagerConfigDiscriminatorManagerType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GroupSchemaManagerConfigDiscriminatorManagerType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GroupSchemaManagerConfigDiscriminatorManagerType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.GroupSchemaManagerConfigDiscriminatorManagerTypeExtensions.ToValueString(value));
        }
    }
}
