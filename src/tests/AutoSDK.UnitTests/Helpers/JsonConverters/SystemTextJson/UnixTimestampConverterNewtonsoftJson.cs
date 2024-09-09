#nullable enable

// ReSharper disable RedundantNameQualifier

// ReSharper disable once CheckNamespace
namespace AutoSDK.JsonConverters
{
    /// <inheritdoc />
    public class UnixTimestampJsonConverterNewtonsoftJson : global::Newtonsoft.Json.JsonConverter<global::System.DateTimeOffset>
    {
        /// <inheritdoc />
        public override global::System.DateTimeOffset ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::System.DateTimeOffset existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            if (reader.TokenType == global::Newtonsoft.Json.JsonToken.Integer)
            {
                switch (reader.Value)
                {
                    case long unixTimestamp:
                        return global::System.DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);
                    case int unixTimestampInt:
                        return global::System.DateTimeOffset.FromUnixTimeSeconds(unixTimestampInt);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::System.DateTimeOffset value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer.WriteValue(value.ToUnixTimeSeconds());
        }
    }
}