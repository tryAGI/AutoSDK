//HintName: G.JsonConverters.RepositoryRuleFileExtensionRestrictionType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class RepositoryRuleFileExtensionRestrictionTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.RepositoryRuleFileExtensionRestrictionType>
    {
        /// <inheritdoc />
        public override global::G.RepositoryRuleFileExtensionRestrictionType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.RepositoryRuleFileExtensionRestrictionType existingValue,
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
                        return global::G.RepositoryRuleFileExtensionRestrictionTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.RepositoryRuleFileExtensionRestrictionType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.RepositoryRuleFileExtensionRestrictionType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.RepositoryRuleFileExtensionRestrictionType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.RepositoryRuleFileExtensionRestrictionTypeExtensions.ToValueString(value));
        }
    }
}
