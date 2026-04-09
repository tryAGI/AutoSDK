//HintName: G.JsonConverters.PhoneNumberControllerUpdateRequestDiscriminatorProvider.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PhoneNumberControllerUpdateRequestDiscriminatorProviderJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider>
    {
        /// <inheritdoc />
        public override global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider existingValue,
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
                        return global::G.PhoneNumberControllerUpdateRequestDiscriminatorProviderExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PhoneNumberControllerUpdateRequestDiscriminatorProvider value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PhoneNumberControllerUpdateRequestDiscriminatorProviderExtensions.ToValueString(value));
        }
    }
}
