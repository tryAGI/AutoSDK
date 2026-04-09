//HintName: G.JsonConverters.DeleteProviderKeyResponseVariant1ProviderName.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteProviderKeyResponseVariant1ProviderNameJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.DeleteProviderKeyResponseVariant1ProviderName>
    {
        /// <inheritdoc />
        public override global::G.DeleteProviderKeyResponseVariant1ProviderName ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.DeleteProviderKeyResponseVariant1ProviderName existingValue,
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
                        return global::G.DeleteProviderKeyResponseVariant1ProviderNameExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.DeleteProviderKeyResponseVariant1ProviderName)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.DeleteProviderKeyResponseVariant1ProviderName);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.DeleteProviderKeyResponseVariant1ProviderName value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.DeleteProviderKeyResponseVariant1ProviderNameExtensions.ToValueString(value));
        }
    }
}
