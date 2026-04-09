//HintName: G.JsonConverters.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1Status.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1StatusJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1Status>
    {
        /// <inheritdoc />
        public override global::G.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1Status ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1Status existingValue,
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
                        return global::G.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1StatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1Status)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1Status);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1Status value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.GetConnectedAccountsByNanoidResponseStateVariant14ValVariant1StatusExtensions.ToValueString(value));
        }
    }
}
