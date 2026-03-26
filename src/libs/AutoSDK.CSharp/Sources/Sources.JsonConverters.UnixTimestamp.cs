using AutoSDK.Models;
using AutoSDK.Serialization.Json;

namespace AutoSDK.Generation;

public static partial class Sources
{
    public static string GenerateUnixTimestampJsonConverter(
        Settings settings,
        CancellationToken cancellationToken = default)
    {
        if (settings.JsonSerializerType == JsonSerializerType.NewtonsoftJson)
        {
            return $@"#nullable enable

namespace {settings.Namespace}.JsonConverters
{{
    /// <inheritdoc />
    public class UnixTimestampJsonConverter : global::Newtonsoft.Json.JsonConverter<global::System.DateTimeOffset>
    {{
        /// <inheritdoc />
        public override global::System.DateTimeOffset ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::System.DateTimeOffset existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {{
            if (reader.TokenType == global::Newtonsoft.Json.JsonToken.Integer)
            {{
                switch (reader.Value)
                {{
                    case long unixTimestamp:
                        if (unixTimestamp >= -62135596800L && unixTimestamp <= 253402300799L)
                        {{
                            return global::System.DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);
                        }}
                    
                        return global::System.DateTimeOffset.FromUnixTimeMilliseconds(unixTimestamp);
                    case int unixTimestampInt:
                        return global::System.DateTimeOffset.FromUnixTimeSeconds(unixTimestampInt);
                }}
            }}

            return default;
        }}

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::System.DateTimeOffset value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {{
            writer.WriteValue(value.ToUnixTimeSeconds());
        }}
    }}
}}
";
        }

        return $@"#nullable enable

namespace {settings.Namespace}.JsonConverters
{{
    /// <inheritdoc />
    public class UnixTimestampJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::System.DateTimeOffset>
    {{
        /// <inheritdoc />
        public override global::System.DateTimeOffset Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            if (reader.TokenType == global::System.Text.Json.JsonTokenType.Number)
            {{
                if (reader.TryGetInt64(out long unixTimestamp))
                {{
                    if (unixTimestamp >= -62135596800L && unixTimestamp <= 253402300799L)
                    {{
                        return global::System.DateTimeOffset.FromUnixTimeSeconds(unixTimestamp);
                    }}
                    
                    return global::System.DateTimeOffset.FromUnixTimeMilliseconds(unixTimestamp);
                }}
                if (reader.TryGetInt32(out int unixTimestampInt))
                {{
                    return global::System.DateTimeOffset.FromUnixTimeSeconds(unixTimestampInt);
                }}
            }}

            return default;
        }}

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::System.DateTimeOffset value,
            global::System.Text.Json.JsonSerializerOptions options)
        {{
            long unixTimestamp = value.ToUnixTimeSeconds();
            writer.WriteNumberValue(unixTimestamp);
        }}
    }}
}}
";
    }
}