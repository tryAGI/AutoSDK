//HintName: G.JsonConverters.CheckRunWithSimpleCheckSuiteConclusion.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CheckRunWithSimpleCheckSuiteConclusionJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CheckRunWithSimpleCheckSuiteConclusion>
    {
        /// <inheritdoc />
        public override global::G.CheckRunWithSimpleCheckSuiteConclusion ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CheckRunWithSimpleCheckSuiteConclusion existingValue,
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
                        return global::G.CheckRunWithSimpleCheckSuiteConclusionExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CheckRunWithSimpleCheckSuiteConclusion)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CheckRunWithSimpleCheckSuiteConclusion);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CheckRunWithSimpleCheckSuiteConclusion value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CheckRunWithSimpleCheckSuiteConclusionExtensions.ToValueString(value));
        }
    }
}
