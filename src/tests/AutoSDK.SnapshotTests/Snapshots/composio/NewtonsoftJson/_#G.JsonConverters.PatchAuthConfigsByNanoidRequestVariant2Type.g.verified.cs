//HintName: G.JsonConverters.PatchAuthConfigsByNanoidRequestVariant2Type.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class PatchAuthConfigsByNanoidRequestVariant2TypeJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.PatchAuthConfigsByNanoidRequestVariant2Type>
    {
        /// <inheritdoc />
        public override global::G.PatchAuthConfigsByNanoidRequestVariant2Type ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.PatchAuthConfigsByNanoidRequestVariant2Type existingValue,
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
                        return global::G.PatchAuthConfigsByNanoidRequestVariant2TypeExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.PatchAuthConfigsByNanoidRequestVariant2Type)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.PatchAuthConfigsByNanoidRequestVariant2Type);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.PatchAuthConfigsByNanoidRequestVariant2Type value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.PatchAuthConfigsByNanoidRequestVariant2TypeExtensions.ToValueString(value));
        }
    }
}
