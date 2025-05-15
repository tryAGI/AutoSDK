﻿//HintName: JsonConverters.UnixTimestamp.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class UnixTimestampJsonConverter : global::Newtonsoft.Json.JsonConverter<global::System.DateTimeOffset>
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
                        if (unixTimestamp >= -62135596800L && unixTimestamp <= 253402300799L)
                        {
                            return global::System.DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);
                        }
                    
                        return global::System.DateTimeOffset.FromUnixTimeMilliseconds(unixTimestamp);
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
