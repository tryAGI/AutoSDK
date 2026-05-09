//HintName: G.JsonConverters.CreateCharacterPerformanceRequestDiscriminatorModel.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateCharacterPerformanceRequestDiscriminatorModelJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CreateCharacterPerformanceRequestDiscriminatorModel>
    {
        /// <inheritdoc />
        public override global::G.CreateCharacterPerformanceRequestDiscriminatorModel ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CreateCharacterPerformanceRequestDiscriminatorModel existingValue,
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
                        return global::G.CreateCharacterPerformanceRequestDiscriminatorModelExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CreateCharacterPerformanceRequestDiscriminatorModel)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CreateCharacterPerformanceRequestDiscriminatorModel);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CreateCharacterPerformanceRequestDiscriminatorModel value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CreateCharacterPerformanceRequestDiscriminatorModelExtensions.ToValueString(value));
        }
    }
}
