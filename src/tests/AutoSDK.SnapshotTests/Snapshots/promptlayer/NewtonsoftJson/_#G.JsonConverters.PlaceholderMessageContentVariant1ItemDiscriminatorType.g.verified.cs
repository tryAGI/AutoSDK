//HintName: G.JsonConverters.PlaceholderMessageContentVariant1ItemDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PlaceholderMessageContentVariant1ItemDiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PlaceholderMessageContentVariant1ItemDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.PlaceholderMessageContentVariant1ItemDiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PlaceholderMessageContentVariant1ItemDiscriminatorType existingValue,
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
                        return global::G.PlaceholderMessageContentVariant1ItemDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PlaceholderMessageContentVariant1ItemDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PlaceholderMessageContentVariant1ItemDiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PlaceholderMessageContentVariant1ItemDiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PlaceholderMessageContentVariant1ItemDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
