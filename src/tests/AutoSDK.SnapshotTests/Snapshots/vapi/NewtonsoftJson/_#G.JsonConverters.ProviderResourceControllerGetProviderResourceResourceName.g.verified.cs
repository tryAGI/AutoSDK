//HintName: G.JsonConverters.ProviderResourceControllerGetProviderResourceResourceName.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ProviderResourceControllerGetProviderResourceResourceNameJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ProviderResourceControllerGetProviderResourceResourceName>
    {
        /// <inheritdoc />
        public override global::G.ProviderResourceControllerGetProviderResourceResourceName ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ProviderResourceControllerGetProviderResourceResourceName existingValue,
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
                        return global::G.ProviderResourceControllerGetProviderResourceResourceNameExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ProviderResourceControllerGetProviderResourceResourceName)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ProviderResourceControllerGetProviderResourceResourceName);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ProviderResourceControllerGetProviderResourceResourceName value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ProviderResourceControllerGetProviderResourceResourceNameExtensions.ToValueString(value));
        }
    }
}
