//HintName: G.JsonConverters.ReposGetOrgRuleSuitesRuleSuiteResult.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReposGetOrgRuleSuitesRuleSuiteResultJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.ReposGetOrgRuleSuitesRuleSuiteResult>
    {
        /// <inheritdoc />
        public override global::G.ReposGetOrgRuleSuitesRuleSuiteResult ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.ReposGetOrgRuleSuitesRuleSuiteResult existingValue,
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
                        return global::G.ReposGetOrgRuleSuitesRuleSuiteResultExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.ReposGetOrgRuleSuitesRuleSuiteResult)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.ReposGetOrgRuleSuitesRuleSuiteResult);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.ReposGetOrgRuleSuitesRuleSuiteResult value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.ReposGetOrgRuleSuitesRuleSuiteResultExtensions.ToValueString(value));
        }
    }
}
