//HintName: G.JsonConverters.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType>
    {
        /// <inheritdoc />
        public override global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType existingValue,
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
                        return global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeExtensions.ToValueString(value));
        }
    }
}
