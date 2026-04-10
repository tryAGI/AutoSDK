//HintName: G.JsonConverters.GroupUpdateManagerConfigVariant1DiscriminatorManagerType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GroupUpdateManagerConfigVariant1DiscriminatorManagerTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType>
    {
        /// <inheritdoc />
        public override global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType existingValue,
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
                        return global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.GroupUpdateManagerConfigVariant1DiscriminatorManagerTypeExtensions.ToValueString(value));
        }
    }
}
