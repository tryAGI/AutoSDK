//HintName: G.JsonConverters.CreateProjectAutomationConfigVariant2CredentialsType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateProjectAutomationConfigVariant2CredentialsTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateProjectAutomationConfigVariant2CredentialsType>
    {
        /// <inheritdoc />
        public override global::G.CreateProjectAutomationConfigVariant2CredentialsType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateProjectAutomationConfigVariant2CredentialsType existingValue,
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
                        return global::G.CreateProjectAutomationConfigVariant2CredentialsTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateProjectAutomationConfigVariant2CredentialsType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateProjectAutomationConfigVariant2CredentialsType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateProjectAutomationConfigVariant2CredentialsType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateProjectAutomationConfigVariant2CredentialsTypeExtensions.ToValueString(value));
        }
    }
}
