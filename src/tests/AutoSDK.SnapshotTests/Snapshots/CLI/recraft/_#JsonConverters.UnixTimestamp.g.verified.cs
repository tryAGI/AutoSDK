﻿//HintName: JsonConverters.UnixTimestamp.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class UnixTimestampJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::System.DateTimeOffset>
    {
        /// <inheritdoc />
        public override global::System.DateTimeOffset Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            if (reader.TokenType == global::System.Text.Json.JsonTokenType.Number)
            {
                if (reader.TryGetInt64(out long unixTimestamp))
                {
                    if (unixTimestamp >= -62135596800L && unixTimestamp <= 253402300799L)
                    {
                        return global::System.DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);
                    }
                    
                    return global::System.DateTimeOffset.FromUnixTimeMilliseconds(unixTimestamp);
                }
                if (reader.TryGetInt32(out int unixTimestampInt))
                {
                    return global::System.DateTimeOffset.FromUnixTimeSeconds(unixTimestampInt);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::System.DateTimeOffset value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            long unixTimestamp = value.ToUnixTimeSeconds();
            writer.WriteNumberValue(unixTimestamp);
        }
    }
}
