//HintName: G.JsonConverters.CodeScanningDefaultSetupQuerySuiteNullable.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodeScanningDefaultSetupQuerySuiteNullableJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CodeScanningDefaultSetupQuerySuite?>
    {
        /// <inheritdoc />
        public override global::G.CodeScanningDefaultSetupQuerySuite? ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CodeScanningDefaultSetupQuerySuite? existingValue,
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
                        return global::G.CodeScanningDefaultSetupQuerySuiteExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CodeScanningDefaultSetupQuerySuite)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CodeScanningDefaultSetupQuerySuite?);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CodeScanningDefaultSetupQuerySuite? value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                writer.WriteValue(global::G.CodeScanningDefaultSetupQuerySuiteExtensions.ToValueString(value.Value));
            }
        }
    }
}
