//HintName: G.JsonConverters.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorTypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType>
    {
        /// <inheritdoc />
        public override global::G.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType existingValue,
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
                        return global::G.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorTypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorType value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ContentBlockSourceContentContentBlockSourceContentItemDiscriminatorTypeExtensions.ToValueString(value));
        }
    }
}
