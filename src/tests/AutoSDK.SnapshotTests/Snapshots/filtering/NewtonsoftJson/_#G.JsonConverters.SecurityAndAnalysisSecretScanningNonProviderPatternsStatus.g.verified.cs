//HintName: G.JsonConverters.SecurityAndAnalysisSecretScanningNonProviderPatternsStatus.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class SecurityAndAnalysisSecretScanningNonProviderPatternsStatusJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.SecurityAndAnalysisSecretScanningNonProviderPatternsStatus>
    {
        /// <inheritdoc />
        public override global::G.SecurityAndAnalysisSecretScanningNonProviderPatternsStatus ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.SecurityAndAnalysisSecretScanningNonProviderPatternsStatus existingValue,
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
                        return global::G.SecurityAndAnalysisSecretScanningNonProviderPatternsStatusExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.SecurityAndAnalysisSecretScanningNonProviderPatternsStatus)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.SecurityAndAnalysisSecretScanningNonProviderPatternsStatus);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.SecurityAndAnalysisSecretScanningNonProviderPatternsStatus value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.SecurityAndAnalysisSecretScanningNonProviderPatternsStatusExtensions.ToValueString(value));
        }
    }
}
